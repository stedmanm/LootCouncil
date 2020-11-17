using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database.Raids
{
    public class MCPopulator : RaidPopulator
    {
        public MCPopulator(ModelBuilder modelBuilder, RaidIds raidIds) : base(modelBuilder, raidIds, "Molten Core", "MC")
        {
        }

        protected override void PopulateRaid()
        {
            PopulateThrash();
            
            PopulateShared();
            
            PopulateLucifron();
            PopulateMagmadar();
            PopulateGehennas();
            PopulateGarr();
            PopulateBaronGeddon();
            PopulateShazzrah();
            PopulateSulfuronHarbinger();
            PopulateGolemagg();
            PopulateMajordomoExecutus();
            PopulateRagnaros();
        }

        private void PopulateLucifron()
        {
            Boss boss = AddBossToRaid("Lucifron");
            AddItemToBoss(boss, "Choker of Enlightenment");
            AddItemToBoss(boss, "T1 - Cenarion Boots");
            AddItemToBoss(boss, "T1 - Felheart Gloves");
            AddItemToBoss(boss, "T1 - Lawbringer Boots");
            AddItemToBoss(boss, "T1 - Gauntlets of Might");
            AddItemToBoss(boss, "T1 - Earthfury Boots");
        }

        private void PopulateMagmadar()
        {
            Boss boss = AddBossToRaid("Magmadar");
            AddItemToBoss(boss, "T1 - Legs");
            AddItemToBoss(boss, "Earthshaker");
            AddItemToBoss(boss, "Eskhandar's Right Claw");
            AddItemToBoss(boss, "Medallion of Steadfast Might");
            AddItemToBoss(boss, "Striker's Mark");
        }

        private void PopulateGehennas()
        {
            Boss boss = AddBossToRaid("Gehennas");
            AddItemToBoss(boss, "T1 - Earthfury Gauntlets");
            AddItemToBoss(boss, "T1 - Giantstalker's Boots");
            AddItemToBoss(boss, "T1 - Gloves of Prophecy");
            AddItemToBoss(boss, "T1 - Lawbringer Gauntlets");
            AddItemToBoss(boss, "T1 - Nightslayer Gloves");
            AddItemToBoss(boss, "T1 - Sabatons of Might");
        }

        private void PopulateGarr()
        {
            Boss boss = AddBossToRaid("Garr");
            AddItemToBoss(boss, "T1 - Helm");
            AddItemToBoss(boss, "Aurastone Hammer");
            AddItemToBoss(boss, "Brutality Blade");
            AddItemToBoss(boss, "Drillborer Disk");
            AddItemToBoss(boss, "Gutgore Ripper");
        }

        private void PopulateShazzrah()
        {
            Boss boss = AddBossToRaid("Shazzrah");
            AddItemToBoss(boss, "T1 - Arcanist Gloves");
            AddItemToBoss(boss, "T1 - Cenarion Gloves");
            AddItemToBoss(boss, "T1 - Giantstalker's Gloves");
            AddItemToBoss(boss, "T1 - Felheart Slippers");
            AddItemToBoss(boss, "T1 - Boots of Prophecy");
            AddItemToBoss(boss, "T1 - Nightslayer Boots");
        }

        private void PopulateBaronGeddon()
        {
            Boss boss = AddBossToRaid("Baron Geddon");
            AddItemToBoss(boss, "T1 - Arcanist Mantle");
            AddItemToBoss(boss, "T1 - Cenarion Spaulders");
            AddItemToBoss(boss, "T1 - Earthfury Epaulets");
            AddItemToBoss(boss, "T1 - Felheart Shoulder Pads");
            AddItemToBoss(boss, "T1 - Lawbringer Spaulders");
            AddItemToBoss(boss, "T1 - Seal of the Archmagus");
        }

        private void PopulateGolemagg()
        {
            Boss boss = AddBossToRaid("Golemagg");
            AddItemToBoss(boss, "T1 - Chest");
            AddItemToBoss(boss, "Azuresong Mageblade");
            AddItemToBoss(boss, "Blastershot Launcher");
            AddItemToBoss(boss, "Staff of Dominance");
        }

        private void PopulateSulfuronHarbinger()
        {
            Boss boss = AddBossToRaid("Sulfuron Harbinger");
            AddItemToBoss(boss, "T1 - Giantstalker's Epaulets");
            AddItemToBoss(boss, "T1 - Mantle of Prophecy");
            AddItemToBoss(boss, "T1 - Nightslayer Shoulder Pads");
            AddItemToBoss(boss, "T1 - Pauldrons of Might");
            AddItemToBoss(boss, "Shadowstrike");
        }

        private void PopulateMajordomoExecutus()
        {
            Boss boss = AddBossToRaid("Majordomo Executus");
            AddItemToBoss(boss, "Ancient Petrified Leaf");
            AddItemToBoss(boss, "Cauterizing Band");
            AddItemToBoss(boss, "Core Forged Greaves");
            AddItemToBoss(boss, "Core Hound Tooth");
            AddItemToBoss(boss, "Finkle's Lava Dredger");
            AddItemToBoss(boss, "Fireguard Shoulders");
            AddItemToBoss(boss, "Fireproof Cloak");
            AddItemToBoss(boss, "Gloves of the Hypnotic Flame");
            AddItemToBoss(boss, "Sash of Whispered Secrets");
            AddItemToBoss(boss, "The Eye of Divinity");
            AddItemToBoss(boss, "Wild Growth Spaulders");
            AddItemToBoss(boss, "Wristguards of True Flight");
        }

        private void PopulateRagnaros()
        {
            Boss boss = AddBossToRaid("Ragnaros");
            AddItemToBoss(boss, "T2 - Legs");
            AddItemToBoss(boss, "Band of Accuria");
            AddItemToBoss(boss, "Band of Sulfuras");
            AddItemToBoss(boss, "Bonereaver's Edge");
            AddItemToBoss(boss, "Choker of the Fire Lord");
            AddItemToBoss(boss, "Cloak of the Shrouded Mists");
            AddItemToBoss(boss, "Crown of Destruction");
            AddItemToBoss(boss, "Dragon's Blood Cape");
            AddItemToBoss(boss, "Essence of the Pure Flame");
            AddItemToBoss(boss, "Malistar's Defender");
            AddItemToBoss(boss, "Onslaught Girdle");
            AddItemToBoss(boss, "Perdition's Blade");
            AddItemToBoss(boss, "Shard of the Flame");
            AddItemToBoss(boss, "Spinal Reaper");
        }

        private void PopulateShared()
        {
            Boss boss = AddSharedBossToRaid();
            AddItemToBoss(boss, "Robe of Volatile Power");
            AddItemToBoss(boss, "Flamewaker Legplates");
            AddItemToBoss(boss, "Ring of Spell Power");
            AddItemToBoss(boss, "Heavy Dark Iron Ring");
            AddItemToBoss(boss, "Manastorm Leggings");
            AddItemToBoss(boss, "Salamander Scale Pants");
            AddItemToBoss(boss, "Wristguards of Stability");
            AddItemToBoss(boss, "Sabatons of the Flamewalker");
            AddItemToBoss(boss, "Magma Tempered Boots");
            AddItemToBoss(boss, "Talisman of Ephemeral Power");
            AddItemToBoss(boss, "Mana Igniting Cord");
            AddItemToBoss(boss, "Aged Core Leather Gloves");
            AddItemToBoss(boss, "Deep Earth Spaulders");
            AddItemToBoss(boss, "Fire Runed Grimoire");
            AddItemToBoss(boss, "Flameguard Gauntlets");
            AddItemToBoss(boss, "Obsidian Edged Blade");
            AddItemToBoss(boss, "Quick Strike Ring");
            AddItemToBoss(boss, "Crimson Shocker");
            AddItemToBoss(boss, "Sorcerous Dagger");
        }

        private void PopulateThrash()
        {
            Boss boss = AddThrashBossToRaid();
            AddItemToBoss(boss, "T1 - Belt");
            AddItemToBoss(boss, "T1 - Bracers");
        }
    }
}
