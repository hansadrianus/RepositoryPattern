using Application.Endpoints.Products.Queries;
using Application.Interfaces.Services;
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

namespace Application.Endpoints.Inventories.Queries
{
    public class GetProductStockQueryHandler : IRequestHandler<GetProductStockQuery, EndpointResult<IEnumerable<ProductStockViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetProductStockQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<ProductStockViewModel>>> Handle(GetProductStockQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<Product, GetProductStockQuery>(request);
            var pids = (await _repository.Product.GetAllAsync(predicates, cancellationToken)).Where(q => q.RowStatus == 0);

            return new EndpointResult<IEnumerable<ProductStockViewModel>>(EndpointResultStatus.Success, _mapper.Map<ProductStockViewModel[]>(pids));
        }
    }
}
