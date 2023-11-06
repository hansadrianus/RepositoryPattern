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

namespace Application.Endpoints.Auths.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, EndpointResult<UserViewModel>>
    {
        private readonly IRequestValidator<UpdateUserCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IEntityMapperService _entityMapper;

        public UpdateUserCommandHandler(IRequestValidator<UpdateUserCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper, IEntityMapperService entityMapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
            _entityMapper = entityMapper;
        }

        public async Task<EndpointResult<UserViewModel>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<UserViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var userToUpdate = _mapper.Map<ApplicationUser>(request);
                var sourceUser = await _repository.Auth.GetAsync(q => q.Id == userToUpdate.Id && q.RowStatus == 0, cancellationToken);
                if (sourceUser == null)
                    return new EndpointResult<UserViewModel>(EndpointResultStatus.Success, "Data not found.");

                var updatedUser = _entityMapper.MapValues(sourceUser, userToUpdate);
                _repository.Auth.Update(updatedUser);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<UserViewModel>(EndpointResultStatus.Success, _mapper.Map<UserViewModel>(updatedUser));
            }
            catch (Exception ex)
            {
                return new EndpointResult<UserViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
