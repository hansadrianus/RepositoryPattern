using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Mappings;
using AutoMapper;
using Infrastructure.Services;
using Library.UnitTest;
using Microsoft.AspNetCore.Http.Extensions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTest
{
    public abstract class BaseUnitTest
    {
        protected IMapper _mapper { get; set; }
        protected Mock<IRepositoryWrapper> _repository { get; set; }
        protected IEntityMapperService _entityMapper { get; set; }
        protected QueryBuilderService _queryBuilder { get; set; }

        [SetUp]
        public void Setup()
        {
            _repository = MockRepositoryWrapper.GetRepositories();
            _entityMapper = new EntityMapperService();
            _queryBuilder = new QueryBuilderService();
        }
    }
}
