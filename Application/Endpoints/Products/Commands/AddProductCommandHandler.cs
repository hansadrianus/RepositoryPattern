using Application.Interfaces;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Endpoints.Products.Commands
{
    internal class AddProductCommandHandler : IRequestHandler<AddProductCommand, EndpointResult<ProductViewModel>>
    {
        private readonly IRequestValidator<AddProductCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public AddProductCommandHandler(IRequestValidator<AddProductCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<ProductViewModel>> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Count() > 0)
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Invalid, validationErrors.ToArray());

            try
            {
                var product = _mapper.Map<Product>(request);
                await _repository.Product.AddAsync(product, cancellationToken);
                await _repository.SaveAsync();

                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Success, _mapper.Map<ProductViewModel>(product));
            }
            catch (Exception ex)
            {
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Error, new string[] { ex.Message });
            }
        }
    }
}
