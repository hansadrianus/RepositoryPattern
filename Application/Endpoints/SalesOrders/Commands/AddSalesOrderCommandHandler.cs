using Application.Interfaces;
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

namespace Application.Endpoints.SalesOrders.Commands
{
    public class AddSalesOrderCommandHandler : IRequestHandler<AddSalesOrderCommand, EndpointResult<SalesOrderViewModel>>
    {
        private readonly IRequestValidator<AddSalesOrderCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IAutoGenerateNumberService _autoGenerateNumberService;

        public AddSalesOrderCommandHandler(IRequestValidator<AddSalesOrderCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IAutoGenerateNumberService autoGenerateNumberService)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _autoGenerateNumberService = autoGenerateNumberService;
        }

        public async Task<EndpointResult<SalesOrderViewModel>> Handle(AddSalesOrderCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var salesOrder = _mapper.Map<SalesOrderHeader>(request);
                salesOrder.SalesOrderDetails = _mapper.Map<IList<SalesOrderDetail>>(request.OrderDetails);
                var lastSalesOrder = await _repository.SalesOrder.GetLastAsync(q => q.OrderNumber.Contains(DateTime.UtcNow.ToString("yyyyMMdd")), q => q.Id, cancellationToken);
                salesOrder.OrderNumber = _autoGenerateNumberService.GenerateOrderNumber("ORD", (lastSalesOrder is null) ? null : lastSalesOrder.OrderNumber, 4);
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
