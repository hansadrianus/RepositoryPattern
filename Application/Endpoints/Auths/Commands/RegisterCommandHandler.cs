using Application.Interfaces;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Endpoints.Auths.Commands
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, EndpointResult<RegisterViewModel>>
    {
        private readonly IRequestValidator<RegisterCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public RegisterCommandHandler(IRequestValidator<RegisterCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<RegisterViewModel>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<RegisterViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var user = _mapper.Map<ApplicationUser>(request);
                var usersFound = await _repository.Auth.GetAsync(q => q.UserName == user.UserName, cancellationToken: cancellationToken);
                if (usersFound != null)
                    return new EndpointResult<RegisterViewModel>(EndpointResultStatus.BadRequest, _mapper.Map<RegisterViewModel>(user), "Username already taken.");

                await _repository.Auth.RegisterUserAsync(user, cancellationToken);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<RegisterViewModel>(EndpointResultStatus.Success, _mapper.Map<RegisterViewModel>(user));
            }
            catch (Exception ex)
            {
                return new EndpointResult<RegisterViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
