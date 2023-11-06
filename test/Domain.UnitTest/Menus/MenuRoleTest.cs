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

namespace Domain.UnitTest.Menus
{
    public class MenuRoleTest : BaseUnitTest
    {
        [SetUp]
        public void SetUp()
        {
            _mapper = new UnitTestMappers().GetMapper<MenuRolesProfileMapper>();
        }

        [Test]
        public void GetMenuRoles_Test()
        {
            // Arrange
            var query = new GetMenuRolesQuery();
            var handler = new GetMenuRolesQueryHandler(_repository.Object, _mapper, _queryBuilder);

            // Act
            var result = handler.Handle(query, CancellationToken.None).Result;

            // Assert
            Assert.That(result.Data, Is.Not.Null);
            Assert.AreEqual(EndpointResultStatus.Success, result.Status);
            if (result.Data.Any())
                Assert.IsAssignableFrom<IEnumerable<MenuViewModel>>(result.Data);
        }
    }
}
