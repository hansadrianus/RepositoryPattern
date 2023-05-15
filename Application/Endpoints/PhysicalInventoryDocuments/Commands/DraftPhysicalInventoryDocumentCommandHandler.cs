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

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class DraftPhysicalInventoryDocumentCommandHandler : IRequestHandler<DraftPhysicalInventoryDocumentCommand, EndpointResult<PhysicalInventoryDocumentViewModel>>
    {
        private readonly IRequestValidator<DraftPhysicalInventoryDocumentCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public DraftPhysicalInventoryDocumentCommandHandler(IRequestValidator<DraftPhysicalInventoryDocumentCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<PhysicalInventoryDocumentViewModel>> Handle(DraftPhysicalInventoryDocumentCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var pid = _mapper.Map<PhysicalInventoryDocumentHeader>(request);
                pid.PhysicalInventoryDetails = _mapper.Map<IList<PhysicalInventoryDocumentDetail>>(request.PhysicalInventoryDocumentDetails);
                await _repository.PhysicalInventoryDocument.AddAsync(pid, cancellationToken);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Success, _mapper.Map<PhysicalInventoryDocumentViewModel>(pid));
            }
            catch (Exception ex)
            {
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
