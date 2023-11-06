using Application.Endpoints.Products.Commands;
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

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class DeletePhysicalInventoryDocumentCommandHandler : IRequestHandler<DeletePhysicalInventoryDocumentCommand, EndpointResult<PhysicalInventoryDocumentViewModel>>
    {
        private readonly IRequestValidator<DeletePhysicalInventoryDocumentCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public DeletePhysicalInventoryDocumentCommandHandler(IRequestValidator<DeletePhysicalInventoryDocumentCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<PhysicalInventoryDocumentViewModel>> Handle(DeletePhysicalInventoryDocumentCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var pid = _mapper.Map<PhysicalInventoryDocumentHeader>(request);
                var pidToDelete = await _repository.PhysicalInventoryDocument.GetAsync(q => q.Id == pid.Id && q.RowStatus == 0, cancellationToken);
                if (pidToDelete == null)
                    return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.NotFound, "Data not found");

                pidToDelete.RowStatus = 1;
                pidToDelete.PhysicalInventoryDetails.ToList().ForEach(q => q.RowStatus = 1);
                _repository.PhysicalInventoryDocument.Update(pidToDelete);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Success, _mapper.Map<PhysicalInventoryDocumentViewModel>(pidToDelete));
            }
            catch (Exception ex)
            {
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
