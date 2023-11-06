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
    public class UpdateDraftSalesOrderCommandHandler : IRequestHandler<UpdateDraftSalesOrderCommand, EndpointResult<SalesOrderViewModel>>
    {
        private readonly IRequestValidator<UpdateDraftSalesOrderCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IEntityMapperService _entityMapperService;

        public UpdateDraftSalesOrderCommandHandler(IRequestValidator<UpdateDraftSalesOrderCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IEntityMapperService entityMapperService)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _entityMapperService = entityMapperService;
        }

        public async Task<EndpointResult<SalesOrderViewModel>> Handle(UpdateDraftSalesOrderCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var orderToUpdate = _mapper.Map<SalesOrderHeader>(request);
                orderToUpdate.SalesOrderDetails = _mapper.Map<IList<SalesOrderDetail>>(request.OrderDetails);
                var sourceOrder = await _repository.SalesOrder.GetAsync(q => q.Id == orderToUpdate.Id && q.RowStatus == 0 && q.IsDraft == true, cancellationToken);
                if (sourceOrder == null)
                    return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.Success, "Data not found.");

                var updatedOrder = _entityMapperService.MapValues(sourceOrder, orderToUpdate);
                _repository.SalesOrder.Update(updatedOrder);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.Success, _mapper.Map<SalesOrderViewModel>(updatedOrder));
            }
            catch (Exception ex)
            {
                return new EndpointResult<SalesOrderViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
