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

namespace Application.Endpoints.OrderTypes.Queries
{
    public class GetOrderTypeQueryHandler : IRequestHandler<GetOrderTypeQuery, EndpointResult<IEnumerable<OrderTypeViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetOrderTypeQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<OrderTypeViewModel>>> Handle(GetOrderTypeQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<OrderType, GetOrderTypeQuery>(request);
            var orderTypes = (await _repository.OrderType.GetAllAsync(predicates, cancellationToken)).Where(q => q.RowStatus == 0);

            return new EndpointResult<IEnumerable<OrderTypeViewModel>>(EndpointResultStatus.Success, _mapper.Map<IEnumerable<OrderTypeViewModel>>(orderTypes));
        }
    }
}
