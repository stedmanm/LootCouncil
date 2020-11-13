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
            SetPageTitle($"Welcome to {user?.Guild.Name ?? "Loot Council"}!");
            return View();
        }
    }
}
