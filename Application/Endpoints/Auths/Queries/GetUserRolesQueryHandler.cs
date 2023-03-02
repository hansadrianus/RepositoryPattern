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
            var userPredicates = _queryBuilder.BuildPredicate<ApplicationUser, GetUserRolesQuery>(request);
            var currentUser = await _repository.Auth.GetAllAsync(userPredicates, cancellationToken);
            var userRoles = await _repository.UserRoles.GetAllAsync(q => q.UserId == request.Id, cancellationToken);
            var roles = await _repository.Role.GetAllAsync(cancellationToken);
            var userRolesView = roles.GroupJoin(
                        userRoles,
                        role => role.Id,
                        userRole => userRole.RoleId,
                        (role, userRoles) => new { Role = role, UserRoles = userRoles })
                    .SelectMany(
                        roleUserRoles => roleUserRoles.UserRoles.DefaultIfEmpty(),
                        (roleUserRoles, userRole) => new { Role = roleUserRoles.Role, UserRole = userRole })
                    .GroupJoin(
                        currentUser,
                        roleUser => roleUser.UserRole != null ? (int?)roleUser.UserRole.UserId : null,
                        user => user.Id,
                        (roleUser, users) => new { Role = roleUser.Role, User = users.DefaultIfEmpty() })
                    .SelectMany(
                        roleUsers => roleUsers.User.Select(
                            user => new UserRolesViewModel
                            {
                                RoleId = roleUsers.Role.Id,
                                RoleName = roleUsers.Role.Name,
                                IsSelected = user != null ? true : false
                            }
                        )
                    );

            return new EndpointResult<IEnumerable<UserRolesViewModel>>(Models.Enumerations.EndpointResultStatus.Success, userRolesView);
        }
    }
}
