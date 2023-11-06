using Application.Endpoints.Menus.Queries;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Mappings;
using Application.Models.Enumerations;
using Application.ViewModels;
using AutoMapper;
using Infrastructure.Services;
using Library.UnitTest;
using Microsoft.AspNetCore.Http;
using Moq;
using System.Net;

namespace Domain.UnitTest.Menus
{
    [TestFixture]
    public class AppMenuTest : BaseUnitTest
    {
        [SetUp]
        public void SetUp()
        {
            _mapper = new UnitTestMappers().GetMapper<MenuProfileMapper>();
        }

        [Test]
        public void GetListMenu_Test()
        {
            // Arrange
            var query = new GetMenuQuery();
            var handler = new GetMenuQueryHandler(_repository.Object, _mapper, _queryBuilder);

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
