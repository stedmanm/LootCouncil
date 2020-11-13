using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Razor;
using LootCouncil.Utilities;
using LootCouncil.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public abstract class ApplicationController : Controller
    {
        private const string addOrEditEntityPath = @"..\Shared\AddOrEditEntity";

        private readonly IControllerServices controllerServices;

        public ApplicationController(IControllerServices controllerServices)
        {
            this.controllerServices = controllerServices;
        }

        protected void AddErrorsToModelState(IdentityResult result)
        {
            AddErrorsToModelState(result.Errors.Select(i => i.Description));
        }

        protected void AddErrorsToModelState(IEnumerable<string> errors)
        {
            foreach (string error in errors)
            {
                AddErrorToModelState(error);
            }
        }

        protected void AddErrorToModelState(string error)
        {
            ModelState.AddModelError(string.Empty, error);
        }

        protected void SetPageTitle(string pageTitle)
        {
            ViewData[RazorPageHelper.PageTitleKey] = pageTitle;
        }

        protected void SetViewName(string htmlFileName)
        {
            ViewData[RazorPageHelper.ViewNameKey] = htmlFileName;
        }

        protected void SetSuccessMessage(string successMessage)
        {
            TempData[RazorPageHelper.SuccessMessageKey] = successMessage;
        }

        protected void SetErrorMessage(string errorMessage)
        {
            TempData[RazorPageHelper.ErrorMessageKey] = errorMessage;
        }

        protected ApplicationUser GetCurrentUser()
        {
            return controllerServices.UserProvider.GetCurrentUser();
        }

        protected IActionResult RedirectToHomePage()
        {
            return RedirectToAction(nameof(HomeController.Index), HomeController.GetName());
        }

        protected IActionResult ViewAddOrEditEntity(string viewName = null)
        {
            if (viewName != null)
                SetViewName(viewName);

            return View(addOrEditEntityPath);
        }

        protected IActionResult ViewAddOrEditEntity(Entity entity, string viewName = null)
        {
            if (viewName != null)
                SetViewName(viewName);

            return View(addOrEditEntityPath, entity);
        }

        protected bool IsModelStateValid => ModelState.IsValid;
    }
}
