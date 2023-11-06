using Application.Endpoints.Auths.Queries;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Menus.Queries
{
    public class GetMenuRolesQueryHandler : IRequestHandler<GetMenuRolesQuery, EndpointResult<IEnumerable<MenuRoleViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetMenuRolesQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<MenuRoleViewModel>>> Handle(GetMenuRolesQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<AppMenuRole, GetMenuRolesQuery>(request);
            var rolePredicates = _queryBuilder.BuildPredicate<ApplicationRole, GetRoleQuery>(_mapper.Map<GetRoleQuery>(request));
            var menuPredicates = _queryBuilder.BuildPredicate<AppMenu, GetMenuQuery>(_mapper.Map<GetMenuQuery>(request));
            var menuRoles = await _repository.MenuRole.GetAllAsync(predicates, cancellationToken);
            var roles = await _repository.Role.GetAllAsync(rolePredicates, cancellationToken);
            var menus = await _repository.AppMenu.GetAllAsync(menuPredicates, cancellationToken);

            return new EndpointResult<IEnumerable<MenuRoleViewModel>>(Models.Enumerations.EndpointResultStatus.Success, MapMenuRoles(roles, menuRoles, menus.Where(q => !string.IsNullOrEmpty(q.MenuAction))));
        }

        private IEnumerable<MenuRoleViewModel> MapMenuRoles(IEnumerable<ApplicationRole> roles, IEnumerable<AppMenuRole> menuRoles, IEnumerable<AppMenu> menus)
        {
            IList<MenuRoleViewModel> menuRolesViewModel = new List<MenuRoleViewModel>();
            foreach (var menu in menus)
            {
                foreach (var role in roles)
                {
                    var existingMenuRole = menuRoles.Where(q => q.AppMenuId == menu.Id && q.RoleId == role.Id);
                    if (existingMenuRole.Any())
                        menuRolesViewModel.Add(new MenuRoleViewModel()
                        {
                            Id = existingMenuRole.FirstOrDefault().Id,
                            AppMenuId = menu.Id,
                            RoleId = role.Id,
                            MenuName = menu.MenuName,
                            IsSelected = true
                        });
                    else
                        menuRolesViewModel.Add(new MenuRoleViewModel()
                        {
                            AppMenuId = menu.Id,
                            RoleId = role.Id,
                            MenuName = menu.MenuName,
                            IsSelected = false
                        });
                }
            }

            return menuRolesViewModel;
        }
    }
}
