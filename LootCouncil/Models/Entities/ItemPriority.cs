using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class ItemPriority : Entity
    {
        [Required]
        [MaxLength(EntityRestrictions.ItemPriorityNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public Item Item { get; set; }

        [Required]
        public IList<CharacterPriority> Priorities { get; set; } = new List<CharacterPriority>();

        public ItemPriority()
        {

        }

        public ItemPriority(string name, Item item, IEnumerable<Character> characters)
        {
            Name = name;
            Item = item;

            foreach (Character character in characters)
                AddCharacterPriority(character);
        }

        public IEnumerable<CharacterPriority> GetOrderedPriorities()
        {
            return Priorities.OrderBy(p => p.Priority);
        }

        public void AddCharacterPriority(Character character)
        {
            if (GetCharacters().Contains(character))
                throw new InvalidOperationException($"{character.Name} was already added to item priority: {Name}.");

            int priority = Priorities.Count + 1;
            Priorities.Add(new CharacterPriority { Character = character, Priority = priority });
        }

        public void DeleteCharacterPriority(Character character)
        {
            int index = IndexOf(character);
            Priorities.RemoveAt(index);
            
            int i = 1;
            //update priorities
            foreach(CharacterPriority characterPriority in GetOrderedPriorities())
            {
                characterPriority.Priority = i;
                i++;
            }
        }

        public void IncreaseCharacterPriority(Character character)
        {
            ModifyPriority(character, true);
        }

        public void DecreaseCharacterPriority(Character character)
        {
            ModifyPriority(character, false);
        }
         
        private void ModifyPriority(Character character, bool increase)
        {
            CharacterPriority characterPriority = Priorities[IndexOf(character)];
            CharacterPriority toSwapWith = Priorities.Single(p => p.Priority == characterPriority.Priority + (increase ? -1 : 1));

            int toSwapWithPriority = toSwapWith.Priority;
            toSwapWith.Priority = characterPriority.Priority;
            characterPriority.Priority = toSwapWithPriority;
        }

        private int IndexOf(Character character)
        {
            return GetCharacters().ToList().IndexOf(character);
        }

        private IEnumerable<Character> GetCharacters()
        {
            return Priorities.Select(p => p.Character);
        }
    }

    public class CharacterPriority : Entity
    {
        [Required]
        public long ItemPriorityId { get; set; }
        [Required]
        public Character Character { get; set; }
        [Required]
        public int Priority { get; set; }
    }
}
