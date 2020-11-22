using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database.Raids
{
    public class AQ40Populator : RaidPopulator
    {
        public AQ40Populator(ModelBuilder modelBuilder, RaidIds raidIds) : base(modelBuilder, raidIds, "The Temple of Ahn'Qiraj", "AQ40")
        {
        }

        protected override void PopulateRaid()
        {
            PopulateThrash();
            PopulateShared();

            PopulateProphetSkeram();

            PopulateYauj();
            PopulateKri();
            PopulateVem();
            //Loot shared between Yauj, Kri and Vem
            PopulateBugTrio();

            PopulateBattleguardSartura();
            PopulateFankriss();

            //Loot shared between Visc and Huhu
            PopulateViscidusAndHuhuran();
            PopulateViscidus();
            PopulatePrincessHuhuran();

            PopulateVeknilashs();
            PopulateVeklors();

            PopulateOuro();
            PopulateCThun();
        }

        private void PopulateThrash()
        {
            Boss boss = AddThrashBossToRaid();
            AddItemToBoss(boss, "Anubisath Warhammer");
            AddItemToBoss(boss, "Garb of Royal Ascension");
            AddItemToBoss(boss, "Gloves of the Immortal");
            AddItemToBoss(boss, "Gloves of the Redeemed Prophecy");
            AddItemToBoss(boss, "Neretzek, The Blood Drinker");
            AddItemToBoss(boss, "Ritssyn's Ring of Chaos");
            AddItemToBoss(boss, "Shard of the Fallen Star");
        }

        private void PopulateShared()
        {
            Boss boss = AddSharedBossToRaid();
            AddItemToBoss(boss, "Imperial Qiraji Armaments");
            AddItemToBoss(boss, "Imperial Qiraji Regalia");
        }

        private void PopulateViscidusAndHuhuran()
        {
            Boss boss = AddBossToRaid(@"Viscidus / Huhuran");
            AddItemToBoss(boss, "T2.5 - Qiraji Bindings of Command");
            AddItemToBoss(boss, "T2.5 - Qiraji Bindings of Dominance");
        }

        private void PopulateProphetSkeram()
        {
            Boss boss = AddBossToRaid("Prophet Skeram");
            AddItemToBoss(boss, "Amulet of Foul Warding");
            AddItemToBoss(boss, "Pendant of the Qiraji Guardian");
            AddItemToBoss(boss, "Cloak of Concentrated Hatred");
            AddItemToBoss(boss, "Leggings of Immersion");
            AddItemToBoss(boss, "Beetle Scaled Wristguards");
            AddItemToBoss(boss, "Boots of the Fallen Prophet");
            AddItemToBoss(boss, "Barrage Shoulders");
            AddItemToBoss(boss, "Breastplate of Annihilation");
            AddItemToBoss(boss, "Boots of the Redeemed Prophecy");
            AddItemToBoss(boss, "Boots of the Unwavering Will");
            AddItemToBoss(boss, "Ring of Swarming Thought");
            AddItemToBoss(boss, "Staff of the Qiraji Prophets");
            AddItemToBoss(boss, "Hammer of Ji'zhi");
        }

        private void PopulateYauj()
        {
            Boss boss = AddBossToRaid("Yauj");
            AddItemToBoss(boss, "Mantle of Phrenic Power");
            AddItemToBoss(boss, "Bile-Covered Gauntlets");
            AddItemToBoss(boss, "Mantle of the Desert's Fury");
            AddItemToBoss(boss, "Mantle of the Desert Crusade");
            AddItemToBoss(boss, "Ukko's Ring of Darkness");
        }

        private void PopulateKri()
        {
            Boss boss = AddBossToRaid("Kri");
            AddItemToBoss(boss, "Vest of Swift Execution");
            AddItemToBoss(boss, "Ring of the Devoured");
            AddItemToBoss(boss, "Petrified Scarab");
            AddItemToBoss(boss, "Wand of Qiraji Nobility");
        }

        private void PopulateVem()
        {
            Boss boss = AddBossToRaid("Vem");
            AddItemToBoss(boss, "Gloves of Ebru");
            AddItemToBoss(boss, "Ooze-ridden Gauntlets");
            AddItemToBoss(boss, "Boots of the Fallen Hero");
            AddItemToBoss(boss, "Angelista's Charm");
        }

        private void PopulateBugTrio()
        {
            Boss boss = AddBossToRaid("Bug Trio");
            AddItemToBoss(boss, "Cape of the Trinity");
            AddItemToBoss(boss, "Robes of the Triumvirate");
            AddItemToBoss(boss, "Ternary Mantle");
            AddItemToBoss(boss, "Guise of the Devourer");
            AddItemToBoss(boss, "Triad Girdle");
            AddItemToBoss(boss, "Angelista's Touch");
        }

        private void PopulateBattleguardSartura()
        {
            Boss boss = AddBossToRaid("Battleguard Sartura");
            AddItemToBoss(boss, "Necklace of Purity");
            AddItemToBoss(boss, "Leggings of the Festering Swarm");
            AddItemToBoss(boss, "Recomposed Boots");
            AddItemToBoss(boss, "Robes of the Battleguard");
            AddItemToBoss(boss, "Silithid Claw");
            AddItemToBoss(boss, "Thick Qirajihide Belt");
            AddItemToBoss(boss, "Creeping Vine Helm");
            AddItemToBoss(boss, "Gloves of Enforcement");
            AddItemToBoss(boss, "Scaled Leggings of Qiraji Fury");
            AddItemToBoss(boss, "Sartura's Might");
            AddItemToBoss(boss, "Gauntlets of Steadfast Determination");
            AddItemToBoss(boss, "Legplates of Blazing Light");
            AddItemToBoss(boss, "Badge of the Swarmguard");
        }

        private void PopulateFankriss()
        {
            Boss boss = AddBossToRaid("Fankriss");
            AddItemToBoss(boss, "Ancient Qiraji Ripper");
            AddItemToBoss(boss, "Barb of the Sand Reaver");
            AddItemToBoss(boss, "Barbed Choker");
            AddItemToBoss(boss, "Cloak of Untold Secrets");
            AddItemToBoss(boss, "Fetish of the Sand Reaver");
            AddItemToBoss(boss, "Hive Tunneler's Boots");
            AddItemToBoss(boss, "Libram of Grace");
            AddItemToBoss(boss, "Mantle of Wicked Revenge");
            AddItemToBoss(boss, "Pauldrons of the Unrelenting");
            AddItemToBoss(boss, "Robes of the Guardian Saint");
            AddItemToBoss(boss, "Scaled Sand Reaver Leggings");
            AddItemToBoss(boss, "Silithid Carapace Chestguard");
            AddItemToBoss(boss, "Totem of Life");
        }

        private void PopulateViscidus()
        {
            Boss boss = AddBossToRaid("Viscidus");
            AddItemToBoss(boss, "Gauntlets of Kalimdor");
            AddItemToBoss(boss, "Idol of Health");
            AddItemToBoss(boss, "Ring of the Qiraji Fury");
            AddItemToBoss(boss, "Scarab Brooch");
            AddItemToBoss(boss, "Sharpened Silithid Femur");
            AddItemToBoss(boss, "Slime-coated Leggings");
        }

        private void PopulatePrincessHuhuran()
        {
            Boss boss = AddBossToRaid("Princess Huhuran");
            AddItemToBoss(boss, "Cloak of the Golden Hive");
            AddItemToBoss(boss, "Gloves of the Messiah");
            AddItemToBoss(boss, "Hive Defiler Wristguards");
            AddItemToBoss(boss, "Huhuran's Stinger");
            AddItemToBoss(boss, "Ring of the Martyr");
            AddItemToBoss(boss, "Wasphide Gauntlets");
        }

        private void PopulateVeknilashs()
        {
            Boss boss = AddBossToRaid("Vek'nilash's");
            AddItemToBoss(boss, "Amulet of Vek'nilash");
            AddItemToBoss(boss, "Belt of the Fallen Emperor");
            AddItemToBoss(boss, "Bracelets of Royal Redemption");
            AddItemToBoss(boss, "Gloves of the Hidden Temple");
            AddItemToBoss(boss, "Grasp of the Fallen Emperor");
            AddItemToBoss(boss, "Kalimdor's Revenge");
            AddItemToBoss(boss, "T2.5 - Vek'nilash's Circlet");
        }

        private void PopulateVeklors()
        {
            Boss boss = AddBossToRaid("Vek'lor's");
            AddItemToBoss(boss, "Boots of Epiphany");
            AddItemToBoss(boss, "Qiraji Execution Bracers");
            AddItemToBoss(boss, "Ring of Emperor Vek'lor");
            AddItemToBoss(boss, "Royal Qiraji Belt");
            AddItemToBoss(boss, "Royal Scepter of Vek'lor");
            AddItemToBoss(boss, "T2.5 - Vek'lor's Diadem");
            AddItemToBoss(boss, "Vek'lor's Gloves of Devastation");
        }

        private void PopulateOuro()
        {
            Boss boss = AddBossToRaid("Ouro");
            AddItemToBoss(boss, "Burrower Bracers");
            AddItemToBoss(boss, "Don Rigoberto's Lost Hat");
            AddItemToBoss(boss, "Jom Gabbar");
            AddItemToBoss(boss, "Larvae of the Great Worm");
            AddItemToBoss(boss, "T2.5 - Ouro's Intact Hide");
            AddItemToBoss(boss, "T2.5 - Skin of the Great Sandworm");
            AddItemToBoss(boss, "The Burrower's Shell");
            AddItemToBoss(boss, "Wormscale Blocker");
        }

        private void PopulateCThun()
        {
            Boss boss = AddBossToRaid("C'Thun");
            AddItemToBoss(boss, "Belt of Never-ending Agony");
            AddItemToBoss(boss, "T2.5 - Carapace of the Old God");
            AddItemToBoss(boss, "Cloak of Clarity");
            AddItemToBoss(boss, "Cloak of the Devoured");
            AddItemToBoss(boss, "Dark Edge of Insanity");
            AddItemToBoss(boss, "Dark Storm Gauntlets");
            AddItemToBoss(boss, "Death's Sting");
            AddItemToBoss(boss, "Eye of C'Thun");
            AddItemToBoss(boss, "Eyestalk Waist Cord");
            AddItemToBoss(boss, "Gauntlets of Annihilation");
            AddItemToBoss(boss, "Grasp of the Old God");
            AddItemToBoss(boss, "T2.5 - Husk of the Old God");
            AddItemToBoss(boss, "Mark of C'Thun");
            AddItemToBoss(boss, "Ring of the Godslayer");
            AddItemToBoss(boss, "Scepter of the False Prophet");
            AddItemToBoss(boss, "Vanquished Tentacle of C'Thun");
        }
    }
}
