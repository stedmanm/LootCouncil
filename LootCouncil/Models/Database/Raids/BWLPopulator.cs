using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database.Raids
{
    public class BWLPopulator : RaidPopulator
    {
        public BWLPopulator(ModelBuilder modelBuilder, RaidIds raidIds) : base(modelBuilder, raidIds, "Blackwing Lair", "BWL")
        {
        }

        protected override void PopulateRaid()
        {
            PopulateThrash();

            PopulateRazorgore();
            PopulateVaelastrasz();
            PopulateBroodlord();
            //Loot shared between Firemaw, Ebonroc, Flamegor.
            PopulateDrakes();
            PopulateFiremaw();
            PopulateEbonroc();
            PopulateFlamegor();
            PopulateChromaggus();
            PopulateNefarian();
        }

        private void PopulateThrash()
        {
            Boss boss = AddThrashBossToRaid();
            AddItemToBoss(boss, "Cloak of Draconic Might");
            AddItemToBoss(boss, "Boots of Pure Thought");
            AddItemToBoss(boss, "Draconic Maul");
            AddItemToBoss(boss, "Doom's Edge");
            AddItemToBoss(boss, "Band of Dark Dominion");
            AddItemToBoss(boss, "Essence Gatherer");
        }

        private void PopulateRazorgore()
        {
            Boss boss = AddBossToRaid("Razorgore");
            AddItemToBoss(boss, "T2 - Wrists");
            AddItemToBoss(boss, "Arcane Infused Gem");
            AddItemToBoss(boss, "The Black Book");
            AddItemToBoss(boss, "Gloves of Rapid Evolution");
            AddItemToBoss(boss, "Mantle of the Blackwing Cabal");
            AddItemToBoss(boss, "Spineshatter");
            AddItemToBoss(boss, "The Untamed Blade");
        }

        private void PopulateVaelastrasz()
        {
            Boss boss = AddBossToRaid("Vaelastrasz");
            AddItemToBoss(boss, "T2 - Belt");
            AddItemToBoss(boss, "Mind Quickening Gem");
            AddItemToBoss(boss, "Rune of Metamorphosis");
            AddItemToBoss(boss, "Pendant of the Fallen Dragon");
            AddItemToBoss(boss, "Helm of Endless Rage");
            AddItemToBoss(boss, "Dragonfang Blade");
            AddItemToBoss(boss, "Red Dragonscale Protector");
        }

        private void PopulateBroodlord()
        {
            Boss boss = AddBossToRaid("Broodlord");
            AddItemToBoss(boss, "T2 - Boots");
            AddItemToBoss(boss, "Lifegiving Gem");
            AddItemToBoss(boss, "Venomous Totem");
            AddItemToBoss(boss, "Black Brood Pauldrons");
            AddItemToBoss(boss, "Bracers of Arcane Accuracy");
            AddItemToBoss(boss, "Heartstriker");
            AddItemToBoss(boss, "Maladath");
        }

        private void PopulateFiremaw()
        {
            Boss boss = AddBossToRaid("Firemaw");
            AddItemToBoss(boss, "Scrolls of Blinding Light");
            AddItemToBoss(boss, "Natural Alignment Crystal");
            AddItemToBoss(boss, "Black Ash Robe");
            AddItemToBoss(boss, "Firemaw's Clutch");
            AddItemToBoss(boss, "Claw of the Black Drake");
            AddItemToBoss(boss, "Cloak of Firemaw");
            AddItemToBoss(boss, "Legguards of the Fallen Crusader");
            AddItemToBoss(boss, "Primalist's Linked Legguards");
        }

        private void PopulateEbonroc()
        {
            Boss boss = AddBossToRaid("Ebonroc");
            AddItemToBoss(boss, "Aegis of Preservation");
            AddItemToBoss(boss, "Band of Forced Concentration");
            AddItemToBoss(boss, "Drake Fang Talisman");
            AddItemToBoss(boss, "Ebony Flame Gloves");
            AddItemToBoss(boss, "Malfurion's Blessed Bulwark");
            AddItemToBoss(boss, "Dragonbreath Hand Cannon");
        }

        private void PopulateFlamegor()
        {
            Boss boss = AddBossToRaid("Flamegor");
            AddItemToBoss(boss, "Shroud of Pure Thought");
            AddItemToBoss(boss, "Circle of Applied Force");
            AddItemToBoss(boss, "Emberweave Leggings");
            AddItemToBoss(boss, "Styleen's Impeding Scarab");
            AddItemToBoss(boss, "Dragon's Touch");
            AddItemToBoss(boss, "Herald of Woe");
        }

        private void PopulateDrakes()
        {
            Boss boss = AddBossToRaid("Drakes");
            AddItemToBoss(boss, "Taut Dragonhide Belt");
            AddItemToBoss(boss, "Drake Talon Pauldrons");
            AddItemToBoss(boss, "Ring of Blackrock");
            AddItemToBoss(boss, "Rejuvenating Gem");
            AddItemToBoss(boss, "Shadow Wing Focus Staff");
            AddItemToBoss(boss, "Drake Talon Cleaver");
        }

        private void PopulateChromaggus()
        {
            Boss boss = AddBossToRaid("Chromaggus");
            AddItemToBoss(boss, "T2 - Shoulders");
            AddItemToBoss(boss, "Angelista's Grasp");
            AddItemToBoss(boss, "Taut Dragonhide Shoulderpads");
            AddItemToBoss(boss, "Chromatic Boots");
            AddItemToBoss(boss, "Taut Dragonhide Gloves");
            AddItemToBoss(boss, "Shimmering Geta");
            AddItemToBoss(boss, "Elementium Threaded Cloak");
            AddItemToBoss(boss, "Girdle of the Fallen Crusader");
            AddItemToBoss(boss, "Empowered Leggings");
            AddItemToBoss(boss, "Chromatically Tempered Sword");
            AddItemToBoss(boss, "Claw of Chromaggus");
            AddItemToBoss(boss, "Primalist's Linked Waistguard");
            AddItemToBoss(boss, "Ashjre'thul, Crossbow of Smiting");
            AddItemToBoss(boss, "Elementium Reinforced Bulwark");
        }

        private void PopulateNefarian()
        {
            Boss boss = AddBossToRaid("Nefarian");
            AddItemToBoss(boss, "T2 - Chest");
            AddItemToBoss(boss, "Head of Nefarian");
            AddItemToBoss(boss, "Cloak of the Brood Lord");
            AddItemToBoss(boss, "Boots of the Shadow Flame");
            AddItemToBoss(boss, "Therazane's Link");
            AddItemToBoss(boss, "Archimtiros' Ring of Reckoning");
            AddItemToBoss(boss, "Neltharion's Tear");
            AddItemToBoss(boss, "Pure Elementium Band");
            AddItemToBoss(boss, "Mish'undare, Circlet of the Mind Flayer");
            AddItemToBoss(boss, "Prestor's Talisman of Connivery");
            AddItemToBoss(boss, "Staff of the Shadow Flame");
            AddItemToBoss(boss, "Ashkandi, Greatsword of the Brotherhood");
            AddItemToBoss(boss, "Crul'shorukh, Edge of Chaos");
            AddItemToBoss(boss, "Lok'amir il Romathis");
        }
    }
}
