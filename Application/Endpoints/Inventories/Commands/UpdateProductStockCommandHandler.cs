using Application.Endpoints.Products.Commands;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Interfaces;
using Application.Models;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Enumerations;
using Domain.Entities;

namespace Application.Endpoints.Inventories.Commands
{
    public class UpdateProductStockCommandHandler : IRequestHandler<UpdateProductStockCommand, EndpointResult<ProductStockViewModel>>
    {
        private readonly IRequestValidator<UpdateProductStockCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IEntityMapperService _entityMapper;

        public UpdateProductStockCommandHandler(IRequestValidator<UpdateProductStockCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IEntityMapperService entityMapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _entityMapper = entityMapper;
        }

        public async Task<EndpointResult<ProductStockViewModel>> Handle(UpdateProductStockCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<ProductStockViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var pidToUpdate = _mapper.Map<Product>(request);
                var sourceProduct = await _repository.Product.GetAsync(q => q.Id == pidToUpdate.Id && q.RowStatus == 0, cancellationToken);
                if (sourceProduct == null)
                    return new EndpointResult<ProductStockViewModel>(EndpointResultStatus.Success, "Data not found.");

                var updatedProduct = _entityMapper.MapValues(sourceProduct, pidToUpdate);
                _repository.Product.Update(updatedProduct);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<ProductStockViewModel>(EndpointResultStatus.Success, _mapper.Map<ProductStockViewModel>(updatedProduct));
            }
            catch (Exception ex)
            {
                return new EndpointResult<ProductStockViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
