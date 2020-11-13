using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LootCouncil.Controllers
{
    [Authorize(Roles = AuthorizationHelper.GuildMasterRole)]
    public class RaidTeamController : ApplicationController
    {
        public static string GetName()
        {
            return ControllerHelper.GetControllerName<RaidTeamController>();
        }

        private readonly IRaidTeamRepository raidTeamRepository;
        private readonly IRaidEventRepository raidEventRepository;

        public RaidTeamController(IControllerServices controllerServices, IRaidTeamRepository raidTeamRepository, IRaidEventRepository raidEventRepository) : base(controllerServices)
        {
            this.raidTeamRepository = raidTeamRepository;
            this.raidEventRepository = raidEventRepository;
        }

        [HttpGet]
        public IActionResult ViewRaidTeams()
        {
            return View(raidTeamRepository.GetRaidTeams());
        }

        [HttpGet]
        public IActionResult AddRaidTeam()
        {
            return ViewAddOrEditEntity();
        }

        [HttpPost]
        public IActionResult AddRaidTeam(RaidTeam raidTeam)
        {
            return AddOrEditRaidTeam(raidTeam);
        }

        [HttpGet]
        public IActionResult EditRaidTeam(long id)
        {
            return ViewAddOrEditEntity(raidTeamRepository.GetRaidTeamById(id));
        }

        [HttpPost]
        public IActionResult EditRaidTeam(RaidTeam raidTeam)
        {
            return AddOrEditRaidTeam(raidTeam);
        }

        [HttpPost]
        public IActionResult DeleteRaidTeam(long id)
        {
            var raidTeam = raidTeamRepository.GetRaidTeamById(id);

            if (raidEventRepository.IsAssociatedWithRaidEvents(raidTeam))
            {
                SetErrorMessage($"Can't delete raid team {raidTeam.Name}, because it is associated with raid events.");
            }
            else
            {
                raidTeamRepository.DeleteRaidTeam(id); 
            }

            return RedirectToAction(nameof(ViewRaidTeams));
        }

        private IActionResult AddOrEditRaidTeam(RaidTeam raidTeam)
        {
            if (!IsModelStateValid)
                return ViewAddOrEditEntity(raidTeam);

            if (raidTeamRepository.GetRaidTeamByName(raidTeam.Name) != null)
            {
                AddErrorToModelState($"Raid team with name {raidTeam.Name} already exists.");
                return ViewAddOrEditEntity(raidTeam);
            }

            if (raidTeam.IsNew)
                raidTeamRepository.AddRaidTeam(raidTeam);
            else
                raidTeamRepository.UpdateRaidTeam(raidTeam);

            return RedirectToAction(nameof(ViewRaidTeams));
        }
    }
}
