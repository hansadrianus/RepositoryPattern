using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.Extensions;

namespace Application.Endpoints.Auths.Queries
{
    public class GetUserProfileHandler : IRequestHandler<GetUserProfile, EndpointResult<IEnumerable<UserProfileViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetUserProfileHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<UserProfileViewModel>>> Handle(GetUserProfile request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<ApplicationUser, GetUserProfile>(request);
            var users = await _repository.Auth.GetAllAsync(predicates, cancellationToken);

            return new EndpointResult<IEnumerable<UserProfileViewModel>>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<IEnumerable<UserProfileViewModel>>(users));
        }
    }
}
