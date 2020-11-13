using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public abstract class LootControllerBase : ApplicationController
    {
        protected readonly IItemRepository ItemRepository;
        protected readonly ICharacterRepository CharacterRepository;

        protected LootControllerBase(IControllerServices controllerServices, IItemRepository itemRepository, ICharacterRepository characterRepository) : base(controllerServices)
        {
            ItemRepository = itemRepository;
            CharacterRepository = characterRepository;
        }

        protected bool TryGetCharacterByName(string name, out Character character)
        {
            character = CharacterRepository.GetCharacterByName(name);

            if (character == null)
            {
                AddErrorToModelState($"Character with name {name} does not exists.");
                return false;
            }

            return true;
        }

        protected bool TryGetItemByName(string name, long raidId, out Item item)
        {
            item = ItemRepository.GetItemByName(new Raid { Id = raidId }, name);
            
            if (item == null)
            {
                AddErrorToModelState($"Item with name {name} does not exists.");
                return false;
            }

            return true;
        }
    }
}
