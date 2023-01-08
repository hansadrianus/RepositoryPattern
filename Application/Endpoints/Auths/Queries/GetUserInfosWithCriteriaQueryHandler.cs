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
    public class GetUserInfosWithCriteriaQueryHandler : IRequestHandler<GetUserInfosWithCriteriaQuery, EndpointResult<IEnumerable<UserLoginViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetUserInfosWithCriteriaQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<UserLoginViewModel>>> Handle(GetUserInfosWithCriteriaQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<ApplicationUser, GetUserInfosWithCriteriaQuery>(request);
            var users = await _repository.Auth.GetAllAsync(predicates, cancellationToken);

            return new EndpointResult<IEnumerable<UserLoginViewModel>>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<IEnumerable<UserLoginViewModel>>(users));
        }
    }
}
