using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    [Authorize]
    public abstract class ApplicationBaseController : Controller
    {
        public ApplicationBaseController()
        {
            ViewData["ApplicationName"] = "Repository Pattern";
            ViewData["CurrentYearString"] = DateTime.Now.ToString("yyyy");
        }
    }
}
