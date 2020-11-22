using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Security;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootCouncil.Razor
{
    public abstract class ExtendedRazorPage<TModel> : RazorPage<TModel>
    {
        protected ExtendedRazorPage()
        {
        }

        [RazorInject]
        protected SignInManager<ApplicationUser> SignInManager { get; set; }

        [RazorInject]
        protected IUserProvider UserProvider { get; set; }

        protected string GetPageTitle()
        {
            return (string)ViewData[RazorPageHelper.PageTitleKey];
        }

        protected string GetViewName()
        {
            if (!ViewData.ContainsKey(RazorPageHelper.ViewNameKey))
                return null;

            return (string)ViewData[RazorPageHelper.ViewNameKey];
        }

        protected string GetSuccessMessage()
        {
            return (string)TempData[RazorPageHelper.SuccessMessageKey];
        }

        protected string GetErrorMessage()
        {
            return (string)TempData[RazorPageHelper.ErrorMessageKey];
        }

        protected string GetWarningMessage()
        {
            return (string)TempData[RazorPageHelper.WarningMessageKey];
        }

        protected bool HasSuccessMessage()
        {
            return TempData.ContainsKey(RazorPageHelper.SuccessMessageKey);
        }

        protected bool HasErrorMessage()
        {
            return TempData.ContainsKey(RazorPageHelper.ErrorMessageKey);
        }

        protected bool HasWarningMessage()
        {
            return TempData.ContainsKey(RazorPageHelper.WarningMessageKey);
        }

        protected bool IsSignedInUser()
        {
            return SignInManager.IsSignedIn(User);
        }

        protected bool IsAdmin()
        {
            return User.IsInRole(ApplicationRole.Admin.ToString()) || IsGuildMaster();
        }

        protected bool IsGuildMaster()
        {
            return User.IsInRole(ApplicationRole.GuildMaster.ToString());
        }

        protected bool IsEntityAdd()
        {
            if (Model == null)
                return true;

            return (Model as Entity).IsNew;
        }

        protected string GetAddOrUpdateButtonName()
        {
            return IsEntityAdd() ? "Add" : "Update";
        }
        
        protected ApplicationUser GetCurrentUser()
        {
            return UserProvider.GetCurrentUser();
        }
    }
}
