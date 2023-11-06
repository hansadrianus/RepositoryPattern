using Application.Endpoints.Auths.Queries;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Menus.Queries
{
    public class GetMenuQueryHandler : IRequestHandler<GetMenuQuery, EndpointResult<IEnumerable<MenuViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetMenuQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<MenuViewModel>>> Handle(GetMenuQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<AppMenu, GetMenuQuery>(request);
            var menus = await _repository.AppMenu.GetAllAsync(predicates, cancellationToken);

            return new EndpointResult<IEnumerable<MenuViewModel>>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<IEnumerable<MenuViewModel>>(menus));
        }
    }
}
