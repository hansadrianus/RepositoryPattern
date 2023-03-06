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
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, EndpointResult<AddUserViewModel>>
    {
        private readonly IRequestValidator<AddUserCommand> _requestValidator;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public AddUserCommandHandler(IRequestValidator<AddUserCommand> requestValidator, IRepositoryWrapper repository, IMapper mapper)
        {
            _requestValidator = requestValidator;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EndpointResult<AddUserViewModel>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Any())
                return new EndpointResult<AddUserViewModel>(EndpointResultStatus.BadRequest, validationErrors.ToArray());

            try
            {
                var newUser = _mapper.Map<ApplicationUser>(request);
                var usersFound = await _repository.Auth.GetAsync(q => q.UserName == newUser.UserName, cancellationToken: cancellationToken);
                if (usersFound != null)
                    return new EndpointResult<AddUserViewModel>(EndpointResultStatus.BadRequest, _mapper.Map<AddUserViewModel>(newUser), "Username already taken.");

                await _repository.Auth.RegisterUserAsync(newUser, cancellationToken);
                await _repository.SaveAsync(cancellationToken);

                return new EndpointResult<AddUserViewModel>(EndpointResultStatus.Success, _mapper.Map<AddUserViewModel>(newUser));
            }
            catch (Exception ex)
            {
                return new EndpointResult<AddUserViewModel>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
