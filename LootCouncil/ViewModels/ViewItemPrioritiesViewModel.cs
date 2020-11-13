using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class ViewItemPrioritiesViewModel
    {
        public Raid Raid { get; set; }
        public ItemPriority SelectedItemPriority { get; set; }
        public ICollection<ItemPriority> ItemPriorities { get; set; }
    }
}
