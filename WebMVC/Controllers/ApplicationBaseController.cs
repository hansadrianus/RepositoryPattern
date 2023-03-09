using Application.Models.Enumerations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    [Authorize]
    public abstract class ApplicationBaseController : Controller
    {
        public void Notify(EndpointResultStatus status, string message = null)
        {
            switch (status)
            {
                case EndpointResultStatus.Success:
                    message = string.IsNullOrEmpty(message) ? "Success" : message;
                    FireNotification(message, NotificationType.success); 
                    break;
                case EndpointResultStatus.Duplicate:
                    message = string.IsNullOrEmpty(message) ? "Warning" : message;
                    FireNotification(message, NotificationType.warning);
                    break;
                case EndpointResultStatus.Gone:
                    message = string.IsNullOrEmpty(message) ? "Information" : message;
                    FireNotification(message, NotificationType.info);
                    break;
                default:
                    message = string.IsNullOrEmpty(message) ? "Error" : message;
                    FireNotification(message, NotificationType.error); 
                    break;
            }
        }

        private void FireNotification(string message, NotificationType notificationType)
        {
            var msg = "$(function() { Toast.fire({ icon: '" + notificationType + "', title: '" + message + "' }) });";
            TempData["Notification"] = msg;
        }

        public override ViewResult View()
        {
            ViewData["ApplicationName"] = "Repository Pattern";
            ViewData["CurrentYearString"] = DateTime.Now.ToString("yyyy");
            return base.View();
        }

        public override ViewResult View(string? viewName)
        {
            ViewData["ApplicationName"] = "Repository Pattern";
            ViewData["CurrentYearString"] = DateTime.Now.ToString("yyyy");
            return base.View(viewName);
        }

        public override ViewResult View(object? model)
        {
            ViewData["ApplicationName"] = "Repository Pattern";
            ViewData["CurrentYearString"] = DateTime.Now.ToString("yyyy");
            return base.View(model);
        }

        public override ViewResult View(string? viewName, object? model)
        {
            ViewData["ApplicationName"] = "Repository Pattern";
            ViewData["CurrentYearString"] = DateTime.Now.ToString("yyyy");
            return base.View(viewName, model);
        }
    }
}
