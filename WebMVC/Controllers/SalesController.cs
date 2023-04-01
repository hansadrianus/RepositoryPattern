using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class SalesController : ApplicationBaseController
    {
        #region View Controllers
        public IActionResult CreateSalesOrder()
        {
            return View();
        }

        public IActionResult ChangeSalesOrder()
        {
            return View();
        }

        public IActionResult DisplaySalesOrder()
        {
            return View();
        }
        #endregion

        #region JSON API Controller

        #endregion
    }
}
