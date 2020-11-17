using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database.Raids
{
    public abstract class RaidPopulator
    {
        private readonly ModelBuilder modelBuilder;
        private readonly RaidIds raidIds;
        private readonly Raid raid;
        private readonly HashSet<string> addedItems = new HashSet<string>();
        
        public RaidPopulator(ModelBuilder modelBuilder, RaidIds raidIds, string raidName, string raidShortName)
        {
            this.modelBuilder = modelBuilder;
            this.raidIds = raidIds;
            raid = CreateRaid(raidName, raidShortName);
        }

        protected abstract void PopulateRaid();

        public static void PopulateRaids(ModelBuilder modelBuilder)
        {
            RaidIds raidIds = new RaidIds();
            new MCPopulator(modelBuilder, raidIds).PopulateRaid();
            new BWLPopulator(modelBuilder, raidIds).PopulateRaid();
        }

        private Raid CreateRaid(string name, string shortName)
        {
            Raid raid = new Raid
            {
                Id = raidIds.RaidId,
                Name = name,
                ShortName = shortName
            };

            modelBuilder.Entity<Raid>().HasData(raid);

            raidIds.RaidId++;
            return raid;
        }

        protected Boss AddBossToRaid(string bossName)
        {
            Boss boss = new Boss
            {
                Id = raidIds.BossId,
                Name = bossName
            };

            modelBuilder.Entity<Boss>().HasData(boss);
            modelBuilder.Entity<RaidHasBoss>().HasData(new { Id = boss.Id, ParentId = raid.Id, ChildId = boss.Id });
            raidIds.BossId++;
            return boss;
        }

        protected Boss AddSharedBossToRaid()
        {
            return AddBossToRaid("Shared");
        }

        protected Boss AddThrashBossToRaid()
        {
            return AddBossToRaid("Thrash");
        }

        protected void AddItemToBoss(Boss boss, string itemName)
        {
            if (addedItems.Contains(itemName))
                throw new ArgumentException($"{itemName} was already added.");

            Item item = new Item
            {
                Id = raidIds.ItemId,
                Name = itemName
            };

            modelBuilder.Entity<Item>().HasData(item);
            modelBuilder.Entity<BossHasItem>().HasData(new { Id = item.Id, ParentId = boss.Id, ChildId = item.Id });
            raidIds.ItemId++;

            addedItems.Add(itemName);
        }
    }
}
