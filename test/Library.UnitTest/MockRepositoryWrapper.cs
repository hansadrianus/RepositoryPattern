using Application.Interfaces.Persistence.AppMenus;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Persistence.LanguageCultures;
using Application.Interfaces.Persistence.OrderTypes;
using Application.Interfaces.Persistence.PaymentTypes;
using Application.Interfaces.Persistence.PhysicalInventoryDocuments;
using Application.Interfaces.Persistence.Products;
using Application.Interfaces.Persistence.SalesOrders;
using Application.Interfaces.Wrappers;
using Domain.Entities;
using Moq;

namespace Library.UnitTest
{
    public class MockRepositoryWrapper
    {
        #region Mocks
        public static Mock<IRepositoryWrapper> GetRepositories()
        {
            var mock = new Mock<IRepositoryWrapper>();
            mock.Setup(m => m.AppMenu).Returns(() => new Mock<IAppMenuRepository>().Object);
            mock.Setup(m => m.Auth).Returns(() => new Mock<IAuthRepository>().Object);
            mock.Setup(m => m.LanguageCulture).Returns(() => new Mock<ILanguageCultureRepository>().Object);
            mock.Setup(m => m.MenuRole).Returns(() => new Mock<IMenuRoleRepository>().Object);
            mock.Setup(m => m.OrderType).Returns(() => new Mock<IOrderTypeRepository>().Object);
            mock.Setup(m => m.PaymentType).Returns(() => new Mock<IPaymentTypeRepository>().Object);
            mock.Setup(m => m.PhysicalInventoryDocument).Returns(() => new Mock<IPhysicalInventoryDocumentRepository>().Object);
            mock.Setup(m => m.Product).Returns(() => new Mock<IProductRepository>().Object);
            mock.Setup(m => m.Role).Returns(() => new Mock<IRoleRepository>().Object);
            mock.Setup(m => m.SalesOrder).Returns(() => new Mock<ISalesOrderRepository>().Object);
            mock.Setup(m => m.UserRoles).Returns(() => new Mock<IUserRoleRepository>().Object);
            mock.Setup(m => m.Save()).Callback(() => { return; });

            var appMenu = CreateAppMenu();
            var languageCulture = CreateLanguageCulture();
            var appMenuRole = CreateAppMenuRole();

            #region Data Mocks
            mock.Setup(m => m.AppMenu.GetAll()).Returns(appMenu);
            mock.Setup(m => m.AppMenu.Get(q => q.Id == It.IsAny<int>())).Returns((int id) => appMenu.FirstOrDefault(q => q.Id == id));
            mock.Setup(m => m.AppMenu.Add(It.IsAny<AppMenu>())).Callback(() => { return; });
            mock.Setup(m => m.AppMenu.Update(It.IsAny<AppMenu>())).Callback(() => { return; });
            mock.Setup(m => m.AppMenu.Remove(It.IsAny<AppMenu>())).Callback(() => { return; });

            mock.Setup(m => m.LanguageCulture.GetAll()).Returns(languageCulture);
            mock.Setup(m => m.LanguageCulture.Get(q => q.Id == It.IsAny<int>())).Returns((int id) => languageCulture.FirstOrDefault(q => q.Id == id));
            mock.Setup(m => m.LanguageCulture.Add(It.IsAny<LanguageCulture>())).Callback(() => { return; });
            mock.Setup(m => m.LanguageCulture.Update(It.IsAny<LanguageCulture>())).Callback(() => { return; });
            mock.Setup(m => m.LanguageCulture.Remove(It.IsAny<LanguageCulture>())).Callback(() => { return; });

            mock.Setup(m => m.MenuRole.GetAll()).Returns(appMenuRole);
            mock.Setup(m => m.MenuRole.Get(q => q.Id == It.IsAny<int>())).Returns((int id) => appMenuRole.FirstOrDefault(q => q.Id == id));
            mock.Setup(m => m.MenuRole.Add(It.IsAny<AppMenuRole>())).Callback(() => { return; });
            mock.Setup(m => m.MenuRole.Update(It.IsAny<AppMenuRole>())).Callback(() => { return; });
            mock.Setup(m => m.MenuRole.Remove(It.IsAny<AppMenuRole>())).Callback(() => { return; });
            #endregion

            return mock;
        }
        #endregion

        #region Data Seed
        private static IList<AppMenu> CreateAppMenu()
        {
            return new List<AppMenu>() {
                new AppMenu { Id = 1, MenuController = "Sales", MenuAction = "", MenuOrder = 0, MenuLevel = 0, MenuName = "Sales", CssClass = "fas fa-dollar-sign", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            };
        }

        private static IList<LanguageCulture> CreateLanguageCulture()
        {
            return new List<LanguageCulture>()
            {
                new LanguageCulture { Id = 1, IsDefaultLanguage = true, LCID = 1033, Description = "English", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            };
        }

        private static IList<AppMenuRole> CreateAppMenuRole()
        {
            return new List<AppMenuRole>() {
                new AppMenuRole { Id = 1, AppMenuId = 1, RoleId = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            };
        }
        #endregion
    }
}
