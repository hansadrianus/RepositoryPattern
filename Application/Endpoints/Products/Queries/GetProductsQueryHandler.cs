using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Endpoints.Products.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, EndpointResult<IEnumerable<ProductViewModel>>>
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IQueryBuilderService _queryBuilder;

        public GetProductsQueryHandler(IRepositoryWrapper repository, IMapper mapper, IQueryBuilderService queryBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _queryBuilder = queryBuilder;
        }

        public async Task<EndpointResult<IEnumerable<ProductViewModel>>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var predicates = _queryBuilder.BuildPredicate<Product, GetProductsQuery>(request);
            var products = (await _repository.Product.GetAllAsync(predicates, cancellationToken)).Where(q => q.RowStatus == 0);

            return new EndpointResult<IEnumerable<ProductViewModel>>(EndpointResultStatus.Success, _mapper.Map<ProductViewModel[]>(products));
        }
    }
}
