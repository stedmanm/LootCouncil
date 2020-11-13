using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Models.Validation;
using LootCouncil.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public class CharacterController : ApplicationController
    {
        private readonly ICharacterRepository characterRepository;

        public static string GetName()
        {
            return ControllerHelper.GetControllerName<CharacterController>();
        }

        public CharacterController(IControllerServices controllerServices, ICharacterRepository characterRepository) : base(controllerServices)
        {
            this.characterRepository = characterRepository;
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddCharacter()
        {
            return ViewAddOrEditEntity();
        }
 
        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult AddCharacter(Character character)
        {
            if (!ValidateCharacter(character))
                return ViewAddOrEditEntity(character);

            characterRepository.AddCharacter(character);

            SetSuccessMessage($"{character.Name} was added sucessfully!");
            return RedirectToAction(nameof(AddCharacter));
        }

        [HttpGet]
        public IActionResult ViewCharacters()
        {
            return View(characterRepository.GetCharacters().OrderBy(c => c.Class).ThenBy(c => c.Name));
        }

        [HttpGet]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult EditCharacter(long id)
        {
            return ViewAddOrEditEntity(characterRepository.GetCharacterById(id));
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult EditCharacter(Character character)
        {
            if (!ValidateCharacter(character))
                return ViewAddOrEditEntity(character);

            characterRepository.UpdateCharacter(character);

            return RedirectToAction(nameof(ViewCharacters));
        }

        [HttpPost]
        [Authorize(Roles = AuthorizationHelper.AdminRoles)]
        public IActionResult DeleteCharacter(long id)
        {
            characterRepository.DeleteCharacter(id);
            return RedirectToAction(nameof(ViewCharacters));
        }

        private bool ValidateCharacter(Character character)
        {
            if (!IsModelStateValid)
                return false;

            CharacterValidator validator = new CharacterValidator(characterRepository);

            ValidationResult result = validator.Validate(character);
            if (!result.Succeeded)
            {
                AddErrorsToModelState(result.Errors);
            }

            return result.Succeeded;
        }
    }
}
