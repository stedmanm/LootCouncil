using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database
{
    public class RaidPopulator
    {
        private readonly ModelBuilder modelBuilder;
        private long raidId = 1;
        private long itemId = 1;
        private long bossId = 1;

        public RaidPopulator(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void PopulateRaids()
        {
            PopulateMC();
            PopulateBWL();
            PopulateAQ();
            PopulateNAXX();
        }

        private void PopulateBWL()
        {
            Raid raid = CreateRaid("Blackwing Lair", "BWL");
        }

        private void PopulateAQ()
        {
            Raid raid = CreateRaid("Temple of Ahn'Qiraj", "AQ40");
        }

        private void PopulateNAXX()
        {
            Raid raid = CreateRaid("Naxxramas", "Naxx");
        }

        private void PopulateMC()
        {
            Raid raid = CreateRaid("Molten Core", "MC");
            Boss boss = AddBossToRaid(raid, "Lucifron");
            AddItemToBoss(boss, "T1 Gloves");
        }

        private Raid CreateRaid(string name, string shortName)
        {
            Raid raid = new Raid
            {
                Id = raidId,
                Name = name,
                ShortName = shortName
            };

            modelBuilder.Entity<Raid>().HasData(raid);

            raidId++;
            return raid;
        }

        private Boss AddBossToRaid(Raid raid, string bossName)
        {
            Boss boss = new Boss
            {
                Id = bossId,
                Name = bossName
            };

            modelBuilder.Entity<Boss>().HasData(boss);
            modelBuilder.Entity<RaidHasBoss>().HasData(new { Id = bossId, ParentId = raid.Id, ChildId = bossId });
            bossId++;
            return boss;
        }

        private void AddItemToBoss(Boss boss, string itemName)
        {
            Item item = new Item
            {
                Id = itemId,
                Name = itemName
            };

            modelBuilder.Entity<Item>().HasData(item);
            modelBuilder.Entity<BossHasItem>().HasData(new { Id = itemId, ParentId = boss.Id, ChildId = itemId });
            itemId++;
        }
    }
}
