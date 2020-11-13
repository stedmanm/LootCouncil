using LootCouncil.Models.Entities;
using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class RaidEventLootViewModel
    {
        public RaidEvent RaidEvent { get; set; }

        public IList<RaidEventLootViewModelItem> Items { get; set; } = new List<RaidEventLootViewModelItem>();
    }

    public class RaidEventLootViewModelItem : Entity
    {
        public string CharacterName { get; set; }
        public string ItemName { get; set; }
        public string BossName { get; set; }
        public string ItemNeedReason { get; set; }
        public string Color { get; set; }

        public RaidEventLootViewModelItem(Loot loot, IDictionary<Item, Boss> bossesByItems)
        {
            Id = loot.Id;
            CharacterName = loot.Character.Name;
            ItemName = loot.Item.Name;
            BossName = bossesByItems[loot.Item].Name;
            ItemNeedReason = loot.ItemNeedReason.DisplayEnum();
            Color = loot.Character.Class.GetClassColor();
        }
    }
}
