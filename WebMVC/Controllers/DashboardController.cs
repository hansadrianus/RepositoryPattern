using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class DashboardController : ApplicationBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
