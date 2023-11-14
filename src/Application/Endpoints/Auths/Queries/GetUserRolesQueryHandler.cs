using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Auths.Queries
{
    public class GetUserRolesQueryHandler : IRequestHandler<GetUserRolesQuery, EndpointResult<IEnumerable<UserRolesViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetUserRolesQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<UserRolesViewModel>>> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
        {
            var userRolesPredicates = _queryBuilder.BuildPredicate<UserRolesViewModel, GetUserRolesQuery>(_mapper.Map<GetUserRolesQuery>(request));
            var userPredicates = _queryBuilder.BuildPredicate<ApplicationUser, GetUserProfileQuery>(_mapper.Map<GetUserProfileQuery>(request));
            var rolePredicates = _queryBuilder.BuildPredicate<ApplicationRole, GetRoleQuery>(_mapper.Map<GetRoleQuery>(request));
            var users = await _repository.Auth.GetAllAsync(userPredicates, cancellationToken);
            var roles = await _repository.Role.GetAllAsync(rolePredicates, cancellationToken);
            var userRoles = (await _repository.UserRoles.GetAllAsync(cancellationToken))
                .GroupJoin(users, ur => ur.UserId, u => u.Id, (userRoles, matchUser) => new { userRoles, matchUser })
                .SelectMany(groupItem => groupItem.matchUser, (groupItem, user) => new ApplicationUserRole()
                {
                    CreatedBy = groupItem.userRoles.CreatedBy,
                    CreatedTime = groupItem.userRoles.CreatedTime,
                    ModifiedBy = groupItem.userRoles.ModifiedBy,
                    ModifiedTime = groupItem.userRoles.ModifiedTime,
                    RoleId = groupItem.userRoles.RoleId,
                    Role = groupItem.userRoles.Role,
                    RowStatus = groupItem.userRoles.RowStatus,
                    RowVersion = groupItem.userRoles.RowVersion,
                    UserId = groupItem.userRoles.UserId,
                    User = user
                })
                .GroupJoin(roles, userRoles => userRoles.RoleId, r => r.Id, (userRoles, matchRole) => new { userRoles, matchRole })
                .SelectMany(groupItem => groupItem.matchRole, (groupItem, role) => new ApplicationUserRole()
                {
                    CreatedBy = groupItem.userRoles.CreatedBy,
                    CreatedTime = groupItem.userRoles.CreatedTime,
                    ModifiedBy = groupItem.userRoles.ModifiedBy,
                    ModifiedTime = groupItem.userRoles.ModifiedTime,
                    RoleId = groupItem.userRoles.RoleId,
                    Role = role,
                    RowStatus = groupItem.userRoles.RowStatus,
                    RowVersion = groupItem.userRoles.RowVersion,
                    UserId = groupItem.userRoles.UserId,
                    User = groupItem.userRoles.User
                });
            var userRolesViewModel = MapUserRolesWithRole(roles, userRoles).Where(userRolesPredicates.Compile());

            return new EndpointResult<IEnumerable<UserRolesViewModel>>(Models.Enumerations.EndpointResultStatus.Success, userRolesViewModel);
        }

        private IEnumerable<UserRolesViewModel> MapUserRolesWithRole(IEnumerable<ApplicationRole> roles, IEnumerable<ApplicationUserRole> userRoles)
        {
            IList<UserRolesViewModel> userRolesViewModel = new List<UserRolesViewModel>();
            foreach (var role in roles)
            {
                userRolesViewModel.Add(new UserRolesViewModel()
                {
                    RoleId = role.Uid,
                    RoleName = role.Name,
                    IsSelected = userRoles.Select(q => q.RoleId).Contains(role.Id) ? true : false
                });
            }

            return userRolesViewModel;
        }
    }
}
