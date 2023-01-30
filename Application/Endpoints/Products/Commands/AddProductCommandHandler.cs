using Application.Interfaces;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Endpoints.Products.Commands
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, EndpointResult<ProductViewModel>>
    {
        private readonly IRequestValidator<AddProductCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IAutoGenerateNumberService _autoGenerateNumberService;

        public AddProductCommandHandler(IRequestValidator<AddProductCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IAutoGenerateNumberService autoGenerateNumberService)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _autoGenerateNumberService = autoGenerateNumberService;
        }

        public async Task<EndpointResult<ProductViewModel>> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var product = _mapper.Map<Product>(request);
                var lastProduct = await _repository.Product.GetLastAsync(q => q.Type == request.Type, cancellationToken);
                product.ProductCode = _autoGenerateNumberService.GenerateCode(request.Type, (lastProduct is null) ? null : lastProduct.ProductCode, 4);
                await _repository.Product.AddAsync(product, cancellationToken); 
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Success, _mapper.Map<ProductViewModel>(product));
            }
            catch (Exception ex)
            {
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
