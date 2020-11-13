using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Security;
using LootCouncil.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public class AccountController : ApplicationController
    {
        private readonly IGuildRepository guildRepository;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IApplicationUserRepository applicationUserRepository;

        public AccountController(IGuildRepository guildRepository, SignInManager<ApplicationUser> signInManager, IApplicationUserRepository applicationUserRepository, IControllerServices controllerServices) 
            : base(controllerServices)
        {
            this.guildRepository = guildRepository;
            this.signInManager = signInManager;
            this.applicationUserRepository = applicationUserRepository;
        }

        public static string GetName()
        {
            return ControllerHelper.GetControllerName<AccountController>();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult CreateGuild()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateGuild(CreateGuildViewModel model)
        {
            if (!IsModelStateValid)
                return View(model);

            if (guildRepository.GetGuildByCode(model.Guild.Code) != null)
            {
                AddErrorToModelState($"Guild with code {model.Guild.Code} already exists.");
                return View(model);
            }

            return await RegisterUserAsync(model, model.Guild, ApplicationRole.GuildMaster);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult JoinGuild()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> JoinGuild(JoinGuildViewModel model)
        {
            if (!IsModelStateValid)
                return View(model);

            var guild = guildRepository.GetGuildByCode(model.GuildCode);

            if (guild == null)
            {
                AddErrorToModelState($"Guild with code {model.GuildCode} does not exists.");
                return View(model);
            }

            if (applicationUserRepository.GetUserByDisplayName(guild, model.DisplayName) != null)
            {
                AddErrorToModelState($"User in guild {model.GuildCode} already has display name {model.DisplayName}.");
                return View(model);
            }

            return await RegisterUserAsync(model, guild, ApplicationRole.Member);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, true);

            if (result.Succeeded)
                return RedirectToHomePage();
            else if (result.IsLockedOut)
            {
                AddErrorToModelState("Account is locked out, try again later.");
                return View(model);
            }

            AddErrorToModelState("Failed login attempt.");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToHomePage();
        }

        private async Task<IActionResult> RegisterUserAsync(RegistrationViewModel model, Guild guild, ApplicationRole applicationRole)
        {
            ApplicationUser applicationUser = new ApplicationUser(model.Email, model.DisplayName, guild);

            var result = await applicationUserRepository.AddUserAsync(applicationUser, model.Password, applicationRole);

            if (result.Succeeded)
                return RedirectToAction(nameof(Login));

            AddErrorsToModelState(result);

            return View(model);
        }
    }
}
