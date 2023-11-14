using Application.Interfaces;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Menus.Commands
{
    public class UpdateMenuRolesCommandHandler : IRequestHandler<UpdateMenuRolesCommand, EndpointResult<MenuRoleViewModel>>
    {
        private readonly IRequestValidator<UpdateMenuRolesCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public UpdateMenuRolesCommandHandler(IRequestValidator<UpdateMenuRolesCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<MenuRoleViewModel>> Handle(UpdateMenuRolesCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<MenuRoleViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var menuRole = _mapper.Map<AppMenuRole>(request);
                var existingMenuRole = await _repository.MenuRole.GetAllAsync(q => q.AppMenuId == menuRole.AppMenuId && q.RoleId == menuRole.RoleId, cancellationToken);
                if (existingMenuRole.Any() && !request.IsSelected)
                    _repository.MenuRole.RemoveRange(existingMenuRole);
                else
                    await _repository.MenuRole.AddAsync(menuRole, cancellationToken);

                await _repository.SaveAsync(cancellationToken);
                var menuRoleView = _mapper.Map<MenuRoleViewModel>(menuRole);
                menuRoleView.IsSelected = request.IsSelected;

                return new EndpointResult<MenuRoleViewModel>(EndpointResultStatus.Success, menuRoleView);
            }
            catch (Exception ex)
            {
                return new EndpointResult<MenuRoleViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
