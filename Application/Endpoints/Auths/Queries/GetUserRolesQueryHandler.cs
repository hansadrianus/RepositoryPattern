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
            var predicates = _queryBuilder.BuildPredicate<ApplicationUserRole, GetUserRolesQuery>(request);
            var rolePredicate = _queryBuilder.BuildPredicate<ApplicationRole, GetRoleQuery>(_mapper.Map<GetRoleQuery>(request));
            var userRoles = await _repository.UserRoles.GetAllAsync(predicates, cancellationToken);
            var roles = await _repository.Role.GetAllAsync(rolePredicate, cancellationToken);

            return new EndpointResult<IEnumerable<UserRolesViewModel>>(Models.Enumerations.EndpointResultStatus.Success, MapUserRolesWithRole(roles, userRoles));
        }

        private IEnumerable<UserRolesViewModel> MapUserRolesWithRole(IEnumerable<ApplicationRole> roles, IEnumerable<ApplicationUserRole> userRoles)
        {
            IList<UserRolesViewModel> userRolesViewModel = new List<UserRolesViewModel>();
            foreach (var role in roles)
            {
                userRolesViewModel.Add(new UserRolesViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    IsSelected = userRoles.Select(q => q.RoleId).Contains(role.Id) ? true : false
                });
            }

            return userRolesViewModel;
        }
    }
}
