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

namespace Application.Endpoints.PaymentTypes.Queries
{
    public class GetPaymentTypeQueryHandler : IRequestHandler<GetPaymentTypeQuery, EndpointResult<IEnumerable<PaymentTypeViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetPaymentTypeQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<PaymentTypeViewModel>>> Handle(GetPaymentTypeQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<PaymentType, GetPaymentTypeQuery>(request);
            var orderTypes = (await _repository.PaymentType.GetAllAsync(predicates, cancellationToken)).Where(q => q.RowStatus == 0);

            return new EndpointResult<IEnumerable<PaymentTypeViewModel>>(EndpointResultStatus.Success, _mapper.Map<IEnumerable<PaymentTypeViewModel>>(orderTypes));
        }
    }
}
