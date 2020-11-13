using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class CharacterLootViewModel
    {
        public Character Character { get; set; }
        public IDictionary<ItemNeedReason, int> CountsByReasons { get; set; } = new Dictionary<ItemNeedReason, int>();
        public IList<CharactLootViewModelItem> Items { get; set; } = new List<CharactLootViewModelItem>();
    }

    public class CharactLootViewModelItem : RaidEventLootViewModelItem
    {
        public string RaidName { get; set; }
        public string RaidDate { get; set; }

        public CharactLootViewModelItem(Loot loot, IDictionary<Item, Boss> bossesByItems) : base(loot, bossesByItems)
        {
        }
    }
}
