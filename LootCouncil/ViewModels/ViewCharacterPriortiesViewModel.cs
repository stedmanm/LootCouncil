using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class ViewCharacterPriortiesViewModel
    {
        public Character Character { get; set; }
        public IList<CharacterPriorityViewModel> Priorities { get; set; } = new List<CharacterPriorityViewModel>();
    }

    public class CharacterPriorityViewModel
    {
        public string ItemName { get; set; }
        public int Priority { get; set; }
        public long ItemPriorityId { get; set; }
    }
}
