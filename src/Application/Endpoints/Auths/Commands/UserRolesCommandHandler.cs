using Application.Interfaces.Wrappers;
using Application.Interfaces;
using Application.Models;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Enumerations;
using Domain.Entities;

namespace Application.Endpoints.Auths.Commands
{
    public class UserRolesCommandHandler : IRequestHandler<UserRolesCommand, EndpointResult<UserRolesViewModel>>
    {
        private readonly IRequestValidator<UserRolesCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public UserRolesCommandHandler(IRequestValidator<UserRolesCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<UserRolesViewModel>> Handle(UserRolesCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<UserRolesViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var userRole = _mapper.Map<ApplicationUserRole>(request);
                var existingUserRole = await _repository.UserRoles.GetAllAsync(q => q.UserId == userRole.UserId && q.RoleId == userRole.RoleId, cancellationToken);
                if (existingUserRole.Any() && !request.IsSelected)
                    _repository.UserRoles.RemoveRange(existingUserRole);
                else
                    await _repository.UserRoles.AddAsync(userRole, cancellationToken);

                await _repository.SaveAsync(cancellationToken);
                var userRoleView = _mapper.Map<UserRolesViewModel>(userRole);
                userRoleView.IsSelected = request.IsSelected;

                return new EndpointResult<UserRolesViewModel>(EndpointResultStatus.Success, userRoleView);
            }
            catch (Exception ex)
            {
                return new EndpointResult<UserRolesViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
