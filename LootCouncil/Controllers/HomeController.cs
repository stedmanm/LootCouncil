using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LootCouncil.Controllers
{
    [AllowAnonymous]
    public class HomeController : ApplicationController
    {
        public static string GetName()
        {
            return ControllerHelper.GetControllerName<HomeController>();
        }

        public HomeController(IControllerServices controllerServices) : base(controllerServices)
        {
        }

        public IActionResult Index()
        {
            var user = GetCurrentUser();

            string pageTitle = $"Welcome to Loot Council!";
            if (user != null)
                pageTitle = $"{user.DisplayName} welcome to {user.Guild.Name}!";

            SetPageTitle(pageTitle);
            return View();
        }
    }
}
