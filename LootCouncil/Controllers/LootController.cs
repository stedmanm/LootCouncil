using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Security;
using LootCouncil.Utilities;
using LootCouncil.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public class LootController : LootControllerBase
    {
        private readonly IRaidEventRepository raidEventRepository;
        private readonly ILootRepository lootRepository;
        private readonly IBossRepository bossRepository;

        public static string GetName()
        {
            return ControllerHelper.GetControllerName<LootController>();
        }

        public LootController(IControllerServices controllerServices, IRaidEventRepository raidEventRepository, IItemRepository itemRepository, ICharacterRepository characterRepository, ILootRepository lootRepository, IBossRepository bossRepository)
            : base(controllerServices, itemRepository, characterRepository)
        {
            this.raidEventRepository = raidEventRepository;
            this.lootRepository = lootRepository;
            this.bossRepository = bossRepository;
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddLoot(long raidEventId)
        {
            return ViewAddOrEditEntity(new LootViewModel { RaidEventId = raidEventId });
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddLoot(LootViewModel model)
        {
            return AddOrEditLoot(model);
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult EditLoot(long id)
        {
            Loot loot = lootRepository.GetLootById(id);
            RaidEvent raidEvent = raidEventRepository.GetRaidEventByLoot(loot);

            var model = new LootViewModel
            {
                Id = loot.Id,
                RaidEventId = raidEvent.Id,
                ItemName = loot.Item.Name,
                CharacterName = loot.Character.Name,
                ItemNeedReason = loot.ItemNeedReason
            };

            return ViewAddOrEditEntity(model);
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult EditLoot(LootViewModel model)
        {
            return AddOrEditLoot(model);
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult DeleteLoot(long id)
        {
            Loot loot = lootRepository.GetLootById(id);
            RaidEvent raidEvent = raidEventRepository.GetRaidEventByLoot(loot);
            lootRepository.DeleteLoot(loot);
            return RedirectToAction(nameof(ViewLoot), new { raidEventId = raidEvent.Id });
        }

        [HttpGet]
        public IActionResult ViewLoot(long raidEventId)
        {
            RaidEvent raidEvent = raidEventRepository.GetRaidEventById(raidEventId);

            IList<Loot> loots = lootRepository.GetLootByRaidEvent(raidEvent);
            IDictionary<Item, Boss> bossesByItems = bossRepository.GetBossesByItems(loots.Select(l => l.Item).ToArray());

            RaidEventLootViewModel model = new RaidEventLootViewModel
            {
                RaidEvent = raidEvent,
                Items = loots.OrderBy(l => bossesByItems[l.Item].Id).Select(l => new RaidEventLootViewModelItem(l, bossesByItems)).ToList()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult ViewLootForCharacter(long characterId)
        {
            Character character = CharacterRepository.GetCharacterById(characterId);

            IList<Loot> loots = lootRepository.GetLootByCharacter(character);
            IDictionary<Loot, RaidEvent> raidEventsByLoot = raidEventRepository.GetRaidEventsByLoot(loots.ToArray());
            IDictionary<Item, Boss> bossesByItems = bossRepository.GetBossesByItems(loots.Select(l => l.Item).ToArray());

            CharacterLootViewModel model = new CharacterLootViewModel
            {
                Character = character
            };

            foreach (Loot loot in loots.OrderByDescending(l => raidEventsByLoot[l].Date)
                                       .ThenByDescending(l => raidEventsByLoot[l].Raid.Id)
                                       .ThenByDescending(l => bossesByItems[l.Item].Id))
            {
                CharactLootViewModelItem item = new CharactLootViewModelItem(loot, bossesByItems)
                {
                    RaidName = raidEventsByLoot[loot].Raid.Name,
                    RaidDate = raidEventsByLoot[loot].Date.ToShortDateString()
                };

                model.Items.Add(item);

                if (model.CountsByReasons.ContainsKey(loot.ItemNeedReason))
                    model.CountsByReasons[loot.ItemNeedReason]++;
                else
                    model.CountsByReasons.Add(loot.ItemNeedReason, 1);
            }

            return View(model);
        }

        private IActionResult AddOrEditLoot(LootViewModel model)
        {
            RaidEvent raidEvent = raidEventRepository.GetRaidEventById(model.RaidEventId);

            if (!IsModelStateValid ||
                !TryGetItemByName(model.ItemName, raidEvent.Raid.Id, out Item item) ||
                !TryGetCharacterByName(model.CharacterName, out Character character))
                return ViewAddOrEditEntity(model);

            Loot loot = model.IsNew ? new Loot() : lootRepository.GetLootById(model.Id);
            loot.Item = item;
            loot.Character = character;
            loot.ItemNeedReason = model.ItemNeedReason;

            Loot existingLoot = lootRepository.GetLootByCharacterAndItem(raidEvent, character, item);

            if (!existingLoot.IsValidEntityForAddOrUpdate(loot))
            {
                AddErrorToModelState($"{character.Name} was already awarded {item.Name} as part of this raid.");
                return ViewAddOrEditEntity(model);
            }

            if (loot.IsNew)
                lootRepository.AddLoot(raidEvent, loot);
            else
                lootRepository.UpdateLoot(loot);

            SetSuccessMessage($"{character.Name} was awarded with {item.Name} for {loot.ItemNeedReason.DisplayEnum()}.");
            return RedirectToAction(nameof(AddLoot), new { raidEventId = raidEvent.Id });
        }
    }
}
