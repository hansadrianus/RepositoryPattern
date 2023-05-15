using Application.Endpoints.PhysicalInventoryDocuments.Commands;
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

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class PostPhysicalInventoryDocumentCommandHandler : IRequestHandler<PostPhysicalInventoryDocumentCommand, EndpointResult<PhysicalInventoryDocumentViewModel>>
    {
        private readonly IRequestValidator<PostPhysicalInventoryDocumentCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IAutoGenerateNumberService _autoGenerateNumberService;

        public PostPhysicalInventoryDocumentCommandHandler(IRequestValidator<PostPhysicalInventoryDocumentCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IAutoGenerateNumberService autoGenerateNumberService)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _autoGenerateNumberService = autoGenerateNumberService;
        }

        public async Task<EndpointResult<PhysicalInventoryDocumentViewModel>> Handle(PostPhysicalInventoryDocumentCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<PhysicalInventoryDocumentViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var pid = _mapper.Map<PhysicalInventoryDocumentHeader>(request);
                pid.PhysicalInventoryDetails = _mapper.Map<IList<PhysicalInventoryDocumentDetail>>(request.PhysicalInventoryDocumentDetails);
                var lastPid = await _repository.PhysicalInventoryDocument.GetLastAsync(q => q.DocumentNo.Contains(DateTime.UtcNow.ToString("yyyyMMdd")), q => q.Id, cancellationToken);
                pid.DocumentNo = _autoGenerateNumberService.GenerateCodeWithUtcDate("PID", (lastPid is null) ? null : lastPid.DocumentNo, 4);
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
