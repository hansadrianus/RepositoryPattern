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
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, EndpointResult<RefreshTokenViewModel>>
    {
        private readonly IRequestValidator<RefreshTokenCommand> _requestValidator;
        private readonly IRepositoryWrapper _reposiroty;
        private readonly IMapper _mapper;

        public RefreshTokenCommandHandler(IRequestValidator<RefreshTokenCommand> requestValidator, IRepositoryWrapper reposiroty, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _reposiroty = reposiroty;
            _mapper = mapper;
        }

        public async Task<EndpointResult<RefreshTokenViewModel>> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<RefreshTokenViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var user = _mapper.Map<ApplicationUser>(request);
                var refreshedToken = await _reposiroty.Auth.RefreshTokenAsync(user, request.Lcid, cancellationToken);
                if (refreshedToken == null)
                    return new EndpointResult<RefreshTokenViewModel>(EndpointResultStatus.Invalid, "Invalid token.");

                return new EndpointResult<RefreshTokenViewModel>(EndpointResultStatus.Success, _mapper.Map<RefreshTokenViewModel>(refreshedToken));
            }
            catch (Exception ex)
            {
                return new EndpointResult<RefreshTokenViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
