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

namespace Application.Endpoints.Auths.Queries
{
    public class GetRoleQueryHandler : IRequestHandler<GetRoleQuery, EndpointResult<IEnumerable<RoleViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetRoleQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<RoleViewModel>>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<ApplicationRole, GetRoleQuery>(_mapper.Map<GetRoleQuery>(request));
            var roles = await _repository.Role.GetAllAsync(predicates, cancellationToken);

            return new EndpointResult<IEnumerable<RoleViewModel>>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<IEnumerable<RoleViewModel>>(roles));
        }
    }
}
