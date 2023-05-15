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
    public class UpdatePostPhysicalInventoryDocumentCommandHandler : IRequestHandler<UpdatePostPhysicalInventoryDocumentCommand, EndpointResult<PhysicalInventoryDocumentViewModel>>
    {
        private readonly IRequestValidator<UpdatePostPhysicalInventoryDocumentCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IEntityMapperService _entityMapperService;

        public UpdatePostPhysicalInventoryDocumentCommandHandler(IRequestValidator<UpdatePostPhysicalInventoryDocumentCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IEntityMapperService entityMapperService)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _entityMapperService = entityMapperService;
        }

        public async Task<EndpointResult<PhysicalInventoryDocumentViewModel>> Handle(UpdatePostPhysicalInventoryDocumentCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var pidToUpdate = _mapper.Map<PhysicalInventoryDocumentHeader>(request);
                pidToUpdate.PhysicalInventoryDetails = _mapper.Map<IList<PhysicalInventoryDocumentDetail>>(request.PhysicalInventoryDocumentDetails);
                var sourcePID = await _repository.PhysicalInventoryDocument.GetAsync(q => q.Id == pidToUpdate.Id && q.RowStatus == 0 && q.IsDraft == false, cancellationToken);
                if (sourcePID == null)
                    return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Success, "Data not found.");

                var updatedPID = _entityMapperService.MapValues(sourcePID, pidToUpdate);
                _repository.PhysicalInventoryDocument.Update(updatedPID);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Success, _mapper.Map<PhysicalInventoryDocumentViewModel>(updatedPID));
            }
            catch (Exception ex)
            {
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
