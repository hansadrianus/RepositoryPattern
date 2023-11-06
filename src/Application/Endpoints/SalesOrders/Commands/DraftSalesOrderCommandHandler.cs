using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Interfaces;
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

namespace Application.Endpoints.SalesOrders.Commands
{
    public class DraftSalesOrderCommandHandler : IRequestHandler<DraftSalesOrderCommand, EndpointResult<SalesOrderViewModel>>
    {
        private readonly IRequestValidator<DraftSalesOrderCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public DraftSalesOrderCommandHandler(IRequestValidator<DraftSalesOrderCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<SalesOrderViewModel>> Handle(DraftSalesOrderCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var salesOrder = _mapper.Map<SalesOrderHeader>(request);
                salesOrder.SalesOrderDetails = _mapper.Map<IList<SalesOrderDetail>>(request.OrderDetails);
                await _repository.SalesOrder.AddAsync(salesOrder, cancellationToken);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.Success, _mapper.Map<SalesOrderViewModel>(salesOrder));
            }
            catch (Exception ex)
            {
                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
