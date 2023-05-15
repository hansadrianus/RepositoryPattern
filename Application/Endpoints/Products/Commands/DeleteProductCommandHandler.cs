using Application.Interfaces;
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
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, EndpointResult<ProductViewModel>>
    {
        private readonly IRequestValidator<DeleteProductCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IRequestValidator<DeleteProductCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<ProductViewModel>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var pid = _mapper.Map<Product>(request);
                var pidToDelete = await _repository.Product.GetAsync(q => q.Id == pid.Id && q.RowStatus == 0, cancellationToken);
                if (pidToDelete == null)
                    return new EndpointResult<ProductViewModel>(EndpointResultStatus.NotFound, "Data not found");

                pidToDelete.RowStatus = 1;
                _repository.Product.Update(pidToDelete);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Success, _mapper.Map<ProductViewModel>(pidToDelete));
            }
            catch (Exception ex)
            {
                return new EndpointResult<ProductViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
