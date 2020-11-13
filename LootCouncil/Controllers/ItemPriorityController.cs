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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public class ItemPriorityController : LootControllerBase
    {
        private readonly IItemPriorityRepository itemPriorityRepository;
        private readonly IRaidRepository raidRepository;

        public static string GetName()
        {
            return ControllerHelper.GetControllerName<ItemPriorityController>();
        }

        public ItemPriorityController(IControllerServices controllerServices, IItemRepository itemRepository, ICharacterRepository characterRepository, IItemPriorityRepository itemPriorityRepository, IRaidRepository raidRepository) : base(controllerServices, itemRepository, characterRepository)
        {
            this.itemPriorityRepository = itemPriorityRepository;
            this.raidRepository = raidRepository;
        }

        [HttpGet]
        public IActionResult ViewItemPrioritiesByRaid(long raidId)
        {
            Raid raid = raidRepository.GetRaidById(raidId);
            return ViewItemPriorities(raid);
        }

        [HttpGet]
        public IActionResult ViewItemPrioritiesBySelected(long selectedId)
        {
            ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityById(selectedId);
            Raid raid = GetRaid(itemPriority);
            return ViewItemPriorities(raid, itemPriority);
        }

        [HttpGet]
        public IActionResult ViewCharacterPriorities(long characterId)
        {
            Character character = CharacterRepository.GetCharacterById(characterId);
            
            ViewCharacterPriortiesViewModel model = new ViewCharacterPriortiesViewModel
            {
                Character = character
            };

            foreach(ItemPriority itemPriority in itemPriorityRepository.GetItemPrioritiesByCharacter(character))
            {
                CharacterPriorityViewModel priority = new CharacterPriorityViewModel
                {
                    ItemName = itemPriority.Item.Name,
                    Priority = itemPriority.Priorities.Single(p => p.Character.Equals(character)).Priority,
                    ItemPriorityId = itemPriority.Id
                };

                model.Priorities.Add(priority);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult EditItemPriorityName(long id)
        {
            ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityById(id);
            
            ItemPriorityNameViewModel model = new ItemPriorityNameViewModel
            {
                Id = id,
                ItemPriorityName = itemPriority.Name
            };

            return ViewEditItemPriorityName(model);
        }

        [HttpPost]
        public IActionResult EditItemPriorityName(ItemPriorityNameViewModel model)
        {
            if (!IsModelStateValid || !ValidateItemPriorityName(model.ItemPriorityName))
                return ViewEditItemPriorityName(model);

            ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityById(model.Id);
            itemPriority.Name = model.ItemPriorityName;
            
            itemPriorityRepository.UpdateItemPriority(itemPriority);

            return RedirectToViewPrioritiesBySelected(itemPriority);
        }

        [HttpGet]
        public IActionResult AddCharacterPriority(long itemPriorityId)
        {
            return View(new AddCharacterPriorityViewModel { ItemPriorityId = itemPriorityId });
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddCharacterPriority(AddCharacterPriorityViewModel model)
        {
            if (!IsModelStateValid)
                return View(model);

            ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityById(model.ItemPriorityId);
            if (!TryAddCharacterPriority(itemPriority, model.CharacterName))
                return View(model);

            itemPriorityRepository.UpdateItemPriority(itemPriority);
            return RedirectToViewPrioritiesBySelected(itemPriority);
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult IncreaseCharacterPriority(long characterPriorityId)
        {
            return ModifyItemPriority(characterPriorityId, nameof(ItemPriority.IncreaseCharacterPriority));
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult DecreaseCharacterPriority(long characterPriorityId)
        {
            return ModifyItemPriority(characterPriorityId, nameof(ItemPriority.DecreaseCharacterPriority));
        }
        
        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult DeleteCharacterPriority(long characterPriorityId)
        {
            return ModifyItemPriority(characterPriorityId, nameof(ItemPriority.DeleteCharacterPriority));
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult DeleteItemPriority(long id)
        {
            ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityById(id);
            itemPriorityRepository.DeleteItemPriority(itemPriority);
            return RedirectToViewPrioritiesByRaid(itemPriority);
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddItemPriority(long raidId)
        {
            return ViewAddOrEditEntity(new ItemPriorityViewModel { RaidId = raidId });
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddItemPriority(ItemPriorityViewModel model)
        {
            if (!IsModelStateValid || !TryGetItemByName(model.ItemName, model.RaidId, out Item item) || !ValidateItemPriorityName(model.ItemPriorityName))
                return ViewAddOrEditEntity(model);

            ItemPriority itemPriority = new ItemPriority
            {
                Item = item,
                Name = model.ItemPriorityName
            };

            foreach (string characterName in model.CharacterNames.Take(ItemPriorityViewModel.CharacterLimit).Where(c => !c.IsNullOrSpaces()))
            {
                if (!TryAddCharacterPriority(itemPriority, characterName))
                    return ViewAddOrEditEntity(model);
            }

            if (itemPriority.Priorities.Count == 0)
            {
                AddErrorToModelState($"Must add atleast one character.");
                return ViewAddOrEditEntity(model);
            }

            itemPriority = itemPriorityRepository.AddItemPriority(itemPriority);
            return RedirectToViewPrioritiesBySelected(itemPriority);
        }

        private IActionResult ModifyItemPriority(long characterPriorityId, string itemPriorityMethodName)
        {
            ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityByCharacterPriorityId(characterPriorityId);

            //Invoke modification method by reflection.
            Character character = itemPriority.Priorities.SingleOrDefault(p => p.Id == characterPriorityId).Character;
            object[] parameters = new object[] { character };
            typeof(ItemPriority).GetMethod(itemPriorityMethodName).Invoke(itemPriority, parameters);
            
            itemPriorityRepository.UpdateItemPriority(itemPriority);

            if (itemPriority.Priorities.Count == 0)
                return RedirectToViewPrioritiesByRaid(itemPriority);
            else
                return RedirectToViewPrioritiesBySelected(itemPriority);
        }

        private IActionResult RedirectToViewPrioritiesByRaid(ItemPriority itemPriority)
        {
            Raid raid = GetRaid(itemPriority);
            return RedirectToAction(nameof(ViewItemPrioritiesByRaid), new { raidId = raid.Id });
        }

        private IActionResult RedirectToViewPrioritiesBySelected(ItemPriority itemPriority)
        {
            return RedirectToAction(nameof(ViewItemPrioritiesBySelected), new { selectedId = itemPriority.Id });
        }

        private Raid GetRaid(ItemPriority itemPriority)
        {
            return raidRepository.GetRaidByItem(itemPriority.Item); 
        }

        private IActionResult ViewItemPriorities(Raid raid, ItemPriority selectedItemPriority = null)
        {
            var model = new ViewItemPrioritiesViewModel
            {
                Raid = raid,
                ItemPriorities = itemPriorityRepository.GetItemPrioritiesByRaid(raid).OrderBy(i => i.Name).ToList(),
                SelectedItemPriority = selectedItemPriority
            };

            if (selectedItemPriority == null)
                model.SelectedItemPriority = model.ItemPriorities.FirstOrDefault() ?? new ItemPriority();

            return View(nameof(ViewItemPriorities), model);
        }

        private IActionResult ViewEditItemPriorityName(ItemPriorityNameViewModel model)
        {
            return ViewAddOrEditEntity(model, "_" + nameof(EditItemPriorityName));
        }

        private bool TryAddCharacterPriority(ItemPriority itemPriority, string characterName)
        {
            if (!TryGetCharacterByName(characterName, out Character character))
                return false;

            ItemPriority existing = itemPriorityRepository.GetItemPriorityByCharacterAndItem(character, itemPriority.Item);

            if (existing != null)
            {
                AddErrorToModelState($"{character.Name} already has a priority on {itemPriority.Item.Name}, as part of {existing.Name}.");
                return false;
            }

            if (itemPriority.Priorities.Select(p => p.Character).Contains(character))
            {
                AddErrorToModelState($"{character.Name} was already added.");
                return false;
            }

            itemPriority.AddCharacterPriority(character);
            return true;
        }

        private bool ValidateItemPriorityName(string name)
        {
            if (itemPriorityRepository.GetItemPriorityByName(name) != null)
            {
                AddErrorToModelState($"Item priority with name {name} already exist.");
                return false;
            }

            return true;
        }
    }
}
