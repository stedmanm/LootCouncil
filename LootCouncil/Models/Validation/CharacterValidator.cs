using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Validation
{
    public class CharacterValidator
    {
        private readonly ICharacterRepository characterRepository;

        public CharacterValidator(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }

        public ValidationResult Validate(Character character)
        {
            ValidationResult result = new ValidationResult();

            Character existingCharacter = characterRepository.GetCharacterByName(character.Name);

            if (!existingCharacter.IsValidEntityForAddOrUpdate(character))
                result.AddError($"Character with name {character.Name} is already in guild.");

            var validClasses = EntityHelpers.GetClassesForRace(character.Race);
            if (!validClasses.Contains(character.Class))
                result.AddError($"{character.Race.DisplayEnum()} can only be one of the following classes: {validClasses.Select(s => s.DisplayEnum()).JoinToString()}.");

            return result;
        }
    }
}
