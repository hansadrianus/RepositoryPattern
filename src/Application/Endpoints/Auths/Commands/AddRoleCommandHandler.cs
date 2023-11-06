using Application.Interfaces;
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
    public class AddRoleCommandHandler : IRequestHandler<AddRoleCommand, EndpointResult<RoleViewModel>>
    {
        private readonly IRequestValidator<AddRoleCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public AddRoleCommandHandler(IRequestValidator<AddRoleCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<RoleViewModel>> Handle(AddRoleCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var role = _mapper.Map<ApplicationRole>(request);
                var existingRole = await _repository.Role.GetAsync(q => q.Name == role.Name, cancellationToken);
                if (existingRole != null)
                    return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.BadRequest, _mapper.Map<RoleViewModel>(role), "Role already exist.");

                await _repository.Role.AddAsync(role, cancellationToken);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<RoleViewModel>(role));
            }
            catch (Exception ex)
            {
                return new EndpointResult<RoleViewModel>(Models.Enumerations.EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
