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

namespace Application.Endpoints.Products.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, EndpointResult<ProductViewModel>>
    {
        private readonly IRequestValidator<UpdateProductCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IEntityMapperService _entityMapper;

        public UpdateProductCommandHandler(IRequestValidator<UpdateProductCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IEntityMapperService entityMapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _entityMapper = entityMapper;
        }

        public async Task<EndpointResult<ProductViewModel>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var productToUpdate = _mapper.Map<Product>(request);
                var sourceProduct = await _repository.Product.GetAsync(q => q.Id == productToUpdate.Id && q.RowStatus == 0);
                if (sourceProduct == null)
                    return new EndpointResult<ProductViewModel>(EndpointResultStatus.Invalid, "Data not found.");

                var updatedProduct = _entityMapper.MapValues(sourceProduct, productToUpdate);
                _repository.Product.Update(updatedProduct);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Success, _mapper.Map<ProductViewModel>(productToUpdate));
            }
            catch (Exception ex)
            {
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
