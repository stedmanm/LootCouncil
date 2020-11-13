using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LootCouncil.Controllers
{
    public static class ControllerHelper
    {
        public static string GetControllerName<T> () where T : Controller
        {
            return typeof(T).Name.ToLower().Replace(nameof(Controller).ToLower(), "");
        }
    }
}
