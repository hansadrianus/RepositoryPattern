using Application.Interfaces;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Auths.Commands
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, EndpointResult<RoleViewModel>>
    {
        private readonly IRequestValidator<UpdateRoleCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IEntityMapperService _entityMapper;

        public UpdateRoleCommandHandler(IRequestValidator<UpdateRoleCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IEntityMapperService entityMapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _entityMapper = entityMapper;
        }

        public async Task<EndpointResult<RoleViewModel>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var roleToUpdate = _mapper.Map<ApplicationRole>(request);
                var sourceRole = await _repository.Role.GetAsync(q => q.Id == roleToUpdate.Id && q.RowStatus == 0, cancellationToken);
                if (sourceRole != null)
                    return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.Success, "Data not found.");

                var updatedRole = _entityMapper.MapValues(sourceRole, roleToUpdate);
                _repository.Role.Update(updatedRole);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<RoleViewModel>(updatedRole));
            }
            catch (Exception ex)
            {
                return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
