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
    public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, EndpointResult<IEnumerable<UserProfileViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetUserProfileQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<UserProfileViewModel>>> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<ApplicationUser, GetUserProfileQuery>(request);
            var users = await _repository.Auth.GetAllAsync(predicates, cancellationToken);

            return new EndpointResult<IEnumerable<UserProfileViewModel>>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<IEnumerable<UserProfileViewModel>>(users));
        }
    }
}
