using Application.Endpoints.Products.Queries;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Endpoints.SalesOrders.Queries
{
    public class GetSalesOrderQueryHandler : IRequestHandler<GetSalesOrderQuery, EndpointResult<IEnumerable<SalesOrderViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetSalesOrderQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<SalesOrderViewModel>>> Handle(GetSalesOrderQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<SalesOrderHeader<int>, GetSalesOrderQuery>(request);
            var salesOrders = (await _repository.SalesOrder.GetAllAsync(predicates, cancellationToken)).Where(q => q.RowStatus == 0);

            return new EndpointResult<IEnumerable<SalesOrderViewModel>>(EndpointResultStatus.Success, _mapper.Map<SalesOrderViewModel[]>(salesOrders));
        }
    }
}
