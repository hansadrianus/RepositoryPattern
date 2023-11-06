using Application.Endpoints.Menus.Queries;
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

namespace Application.Endpoints.LanguageCultures.Queries
{
    public class GetLanguageCultureQueryHandler : IRequestHandler<GetLanguageCultureQuery, EndpointResult<IEnumerable<LanguageCultureViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetLanguageCultureQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<LanguageCultureViewModel>>> Handle(GetLanguageCultureQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<LanguageCulture, GetLanguageCultureQuery>(request);
            var languages = await _repository.LanguageCulture.GetAllAsync(predicates, cancellationToken);

            return new EndpointResult<IEnumerable<LanguageCultureViewModel>>(Models.Enumerations.EndpointResultStatus.Success, _mapper.Map<IEnumerable<LanguageCultureViewModel>>(languages));
        }
    }
}
