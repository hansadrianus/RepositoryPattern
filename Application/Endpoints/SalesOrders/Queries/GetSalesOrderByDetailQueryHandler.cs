using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
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

namespace Application.Endpoints.SalesOrders.Queries
{
    public class GetSalesOrderByDetailQueryHandler : IRequestHandler<GetSalesOrderByDetailQuery, EndpointResult<IEnumerable<SalesOrderViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetSalesOrderByDetailQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<SalesOrderViewModel>>> Handle(GetSalesOrderByDetailQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<SalesOrderDetail<int>, GetSalesOrderByDetailQuery>(request);
            var orders = (await _repository.SalesOrder.GetAllAsync(q => q.SalesOrderDetails.AsQueryable().Any(predicates), cancellationToken)).Where(q => q.RowStatus == 0);

            return new EndpointResult<IEnumerable<SalesOrderViewModel>>(EndpointResultStatus.Success, _mapper.Map<SalesOrderViewModel[]>(orders));
        }
    }
}
