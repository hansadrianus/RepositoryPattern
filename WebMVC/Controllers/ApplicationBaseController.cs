﻿using Application.Models.Enumerations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    [Authorize]
    public abstract class ApplicationBaseController : Controller
    {
        public void Notify(string message, EndpointResultStatus status)
        {
            switch (status)
            {
                case EndpointResultStatus.Success:
                    FireNotification(message, NotificationType.success); break;
                case EndpointResultStatus.Duplicate:
                    FireNotification(message, NotificationType.warning); break;
                case EndpointResultStatus.Gone:
                    FireNotification(message, NotificationType.info); break;
                default:
                    FireNotification(message, NotificationType.error); break;
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
