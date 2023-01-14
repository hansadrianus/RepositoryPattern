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
    public class LoginCommandHandler : IRequestHandler<LoginCommand, EndpointResult<UserLoginViewModel>>
    {
        private readonly IRequestValidator<LoginCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public LoginCommandHandler(IRequestValidator<LoginCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<UserLoginViewModel>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Count() > 0)
                return new EndpointResult<UserLoginViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var user = _mapper.Map<ApplicationUser>(request);
                bool isAuthenticated = await _repository.Auth.ValidateUserAsync(user, cancellationToken);
                if (isAuthenticated)
                {
                    var userToken = await _repository.Auth.CreateTokenAsync(user, cancellationToken);
                    return new EndpointResult<UserLoginViewModel>(EndpointResultStatus.Success, _mapper.Map<UserLoginViewModel>(userToken));
                }

                return new EndpointResult<UserLoginViewModel>(EndpointResultStatus.Unauthorized, "Invalid login attempt." );
            }
            catch (Exception ex)
            {
                return new EndpointResult<UserLoginViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
