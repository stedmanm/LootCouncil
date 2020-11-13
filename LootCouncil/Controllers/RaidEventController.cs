using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Security;
using LootCouncil.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LootCouncil.Controllers
{
    public class RaidEventController : ApplicationController
    {
        private readonly IRaidRepository raidRepository;
        private readonly IRaidTeamRepository raidTeamRepository;
        private readonly IRaidEventRepository raidEventRepository;
        private readonly ILootRepository lootRepository;

        public RaidEventController(IControllerServices controllerServices, IRaidRepository raidRepository, IRaidTeamRepository raidTeamRepository, IRaidEventRepository raidEventRepository, ILootRepository lootRepository) : base(controllerServices)
        {
            this.raidRepository = raidRepository;
            this.raidTeamRepository = raidTeamRepository;
            this.raidEventRepository = raidEventRepository;
            this.lootRepository = lootRepository;
        }

        public static string GetName()
        {
            return ControllerHelper.GetControllerName<RaidEventController>();
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddRaidEvent()
        {
            return ViewAddOrEditEntity();
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddRaidEvent(RaidEventViewModel model)
        {
            return AddOrEditRaidEvent(model);
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult EditRaidEvent(long id)
        {
            var raidEvent = raidEventRepository.GetRaidEventById(id);
            
            RaidEventViewModel raidEventViewModel = new RaidEventViewModel
            {
                Id = id,
                RaidId = raidEvent.Raid.Id,
                RaidTeamId = raidEvent.RaidTeam.Id,
                Date = raidEvent.Date
            };

            return ViewAddOrEditEntity(raidEventViewModel);
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult EditRaidEvent(RaidEventViewModel model)
        {
            return AddOrEditRaidEvent(model);
        }

        [HttpGet]
        public IActionResult ViewRaidEvents()
        {
            return View(raidEventRepository.GetLatestRaidEvents(100));
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult DeleteRaidEvent(long id)
        {
            RaidEvent raidEvent = raidEventRepository.GetRaidEventById(id);

            if (lootRepository.HasLoot(raidEvent))
            {
                SetErrorMessage("Raid event cannot be deleted, because there is loot associated with it.");
            }
            else
            {
                raidEventRepository.DeleteRaidEvent(raidEvent);
            }

            return RedirectToAction(nameof(ViewRaidEvents));
        }

        private IActionResult AddOrEditRaidEvent(RaidEventViewModel model)
        {
            if (!IsModelStateValid)
                return ViewAddOrEditEntity(model);

            RaidEvent raidEvent = BuildRaidEvent(model);

            if (raidEventRepository.DoesRaidEventExist(raidEvent))
            {
                AddErrorToModelState("This raid event already exists.");
                return ViewAddOrEditEntity(model);
            }

            if (raidEvent.IsNew)
                raidEventRepository.AddRaidEvent(raidEvent);
            else
                raidEventRepository.UpdateRaidEvent(raidEvent);

            return RedirectToAction(nameof(ViewRaidEvents));
        }

        private RaidEvent BuildRaidEvent(RaidEventViewModel model)
        {
            RaidEvent raidEvent = model.IsNew ? new RaidEvent() : raidEventRepository.GetRaidEventById(model.Id);
            raidEvent.Date = model.Date;
            raidEvent.RaidTeam = raidTeamRepository.GetRaidTeamById(model.RaidTeamId);

            if (model.IsNew)
                raidEvent.Raid = raidRepository.GetRaidById(model.RaidId);

            return raidEvent;
        }
    }
}
