using Application.Endpoints.LanguageCultures.Queries;
using Application.Endpoints.Menus.Queries;
using Application.Mappings;
using Application.Models.Enumerations;
using Application.ViewModels;
using Library.UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTest.LanguageCultures
{
    public class LanguageCultureTest : BaseUnitTest
    {
        [SetUp]
        public void SetUp()
        {
            _mapper = new UnitTestMappers().GetMapper<LanguageCultureProfileMapper>();
        }

        [Test]
        public void GetListLanguageCultures_Test()
        {
            // Arrange
            var query = new GetLanguageCultureQuery();
            var handler = new GetLanguageCultureQueryHandler(_repository.Object, _mapper, _queryBuilder);

            // Act
            var result = handler.Handle(query, CancellationToken.None).Result;

            // Assert
            Assert.That(result.Data, Is.Not.Null);
            Assert.AreEqual(EndpointResultStatus.Success, result.Status);
            if (result.Data.Any())
                Assert.IsAssignableFrom<IEnumerable<LanguageCultureViewModel>>(result.Data);
        }
    }
}
