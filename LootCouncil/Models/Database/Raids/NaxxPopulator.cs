using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database.Raids
{
    public class NaxxPopulator : RaidPopulator
    {
        public NaxxPopulator(ModelBuilder modelBuilder, RaidIds raidIds) : base(modelBuilder, raidIds, "Naxxramas", "Naxx")
        {
        }

        protected override void PopulateRaid()
        {
            PopulateThrash();

            //Spider Wing
            PopulateAnubRekhan();
            PopulateGrandWidowFaerlina();
            PopulateFaerlinaAndAnubRekhan();
            PopulateMaexxna();

            //Plague Wing
            PopulateNothThePlaguebringer();
            PopulateHeiganTheUnclean();
            PopulateNothAndHeigan();
            PopulateLoatheb();

            //Deathknight Wing
            PopulateInstructorRazuvious();
            PopulateGothikTheHarvester();
            PopulateRazuviousAndGothik();
            PopulateTheFourHorsemen();

            //Abomination Wing
            PopulatePatchwerk();
            PopulateGrobbulus();
            PopulatePatchwerkAndGrobbulus();
            PopulateGluth();
            PopulateThaddius();

            PopulateSapphiron();
            PopulateKelThuzad();
        }

        private void PopulateThrash()
        {
            Boss boss = AddThrashBossToRaid();
            AddItemToBoss(boss, "Belt of the Grand Crusader");
            AddItemToBoss(boss, "Ghoul Skin Tunic");
            AddItemToBoss(boss, "Girdle of Elemental Fury");
            AddItemToBoss(boss, "Harbinger of Doom");
            AddItemToBoss(boss, "Leggings of Elemental Fury");
            AddItemToBoss(boss, "Leggings of the Grand Crusader");
            AddItemToBoss(boss, "Misplaced Servo Arm");
            AddItemToBoss(boss, "Necro-Knight's Garb");
            AddItemToBoss(boss, "Pauldrons of Elemental Fury");
            AddItemToBoss(boss, "Spaulders of the Grand Crusader");
            AddItemToBoss(boss, "Stygian Buckler");
            AddItemToBoss(boss, "Ring of the Eternal Flame");
        }

        private void PopulateAnubRekhan()
        {
            Boss boss = AddBossToRaid("Anub'Rekhan");
            AddItemToBoss(boss, "Band of Unanswered Prayers");
            AddItemToBoss(boss, "Cryptfiend Silk Cloak");
            AddItemToBoss(boss, "Gem of Nerubis");
            AddItemToBoss(boss, "Touch of Frost");
            AddItemToBoss(boss, "Wristguards of Vengeance");
        }

        private void PopulateGrandWidowFaerlina()
        {
            Boss boss = AddBossToRaid("Grand Widow Faerlina");
            AddItemToBoss(boss, "Icebane Pauldrons");
            AddItemToBoss(boss, "Malice Stone Pendant");
            AddItemToBoss(boss, "Polar Shoulder Pads");
            AddItemToBoss(boss, "The Widow's Embrace");
            AddItemToBoss(boss, "Widow's Remorse");
        }

        private void PopulateFaerlinaAndAnubRekhan()
        {
            Boss boss = AddBossToRaid(@"Anub'Rekhan / Faerlina");
            AddItemToBoss(boss, "T3 - Desecrated Bindings");
            AddItemToBoss(boss, "T3 - Desecrated Bracers");
            AddItemToBoss(boss, "T3 - Desecrated Wristguards");
        }

        private void PopulateMaexxna()
        {
            Boss boss = AddBossToRaid("Maexxna");
            AddItemToBoss(boss, "Crystal Webbed Robe");
            AddItemToBoss(boss, "T3 - Desecrated Gauntlets");
            AddItemToBoss(boss, "T3 - Desecrated Gloves");
            AddItemToBoss(boss, "T3 - Desecrated Handguards");
            AddItemToBoss(boss, "Kiss of the Spider");
            AddItemToBoss(boss, "Maexxna's Fang");
            AddItemToBoss(boss, "Pendant of Forgotten Names");
            AddItemToBoss(boss, "Wraith Blade");
        }

        private void PopulateNothThePlaguebringer()
        {
            Boss boss = AddBossToRaid("Noth the Plaguebringer");
            AddItemToBoss(boss, "Cloak of the Scourge");
            AddItemToBoss(boss, "Noth's Frigid Heart");
            AddItemToBoss(boss, "Band of the Inevitable");
            AddItemToBoss(boss, "Hailstone Band");
            AddItemToBoss(boss, "Hatchet of Sundered Bone");
            AddItemToBoss(boss, "Libram of Light");
            AddItemToBoss(boss, "Totem of Flowing Water");
        }

        private void PopulateHeiganTheUnclean()
        {
            Boss boss = AddBossToRaid("Heigan the Unclean");
            AddItemToBoss(boss, "Legplates of Carnage");
            AddItemToBoss(boss, "Icy Scale Coif");
            AddItemToBoss(boss, "Preceptor's Hat");
            AddItemToBoss(boss, "Icebane Helmet");
            AddItemToBoss(boss, "Necklace of Necropsy");
        }

        private void PopulateNothAndHeigan()
        {
            Boss boss = AddBossToRaid(@"Noth / Heigan");
            AddItemToBoss(boss, "T3 - Desecrated Waistguard");
            AddItemToBoss(boss, "T3 - Desecrated Belt");
            AddItemToBoss(boss, "T3 - Desecrated Girdle");
        }

        private void PopulateLoatheb()
        {
            Boss boss = AddBossToRaid("Loatheb");
            AddItemToBoss(boss, "T3 - Desecrated Legplates");
            AddItemToBoss(boss, "T3 - Desecrated Leggings");
            AddItemToBoss(boss, "T3 - Desecrated Legguards");
            AddItemToBoss(boss, "Band of Unnatural Forces");
            AddItemToBoss(boss, "The Eye of Nerub");
            AddItemToBoss(boss, "Ring of Spiritual Fervor");
            AddItemToBoss(boss, "Brimstone Staff");
            AddItemToBoss(boss, "Loatheb's Reflection");
        }

        private void PopulateInstructorRazuvious()
        {
            Boss boss = AddBossToRaid("Instructor Razuvious");
            AddItemToBoss(boss, "Wand of the Whispering Dead");
            AddItemToBoss(boss, "Signet of the Fallen Defender");
            AddItemToBoss(boss, "Idol of Longevity");
            AddItemToBoss(boss, "Girdle of the Mentor");
            AddItemToBoss(boss, "Veil of Eclipse");
            AddItemToBoss(boss, "Iblis, Blade of the Fallen Seraph");
        }

        private void PopulateGothikTheHarvester()
        {
            Boss boss = AddBossToRaid("Gothik the Harvester");
            AddItemToBoss(boss, "Boots of Displacement");
            AddItemToBoss(boss, "Glacial Headdress");
            AddItemToBoss(boss, "Polar Helmet");
            AddItemToBoss(boss, "Sadist's Collar");
            AddItemToBoss(boss, "The Soul Harvester's Bindings");
        }

        private void PopulateRazuviousAndGothik()
        {
            Boss boss = AddBossToRaid(@"Razuvious / Gothik");
            AddItemToBoss(boss, "T3 - Desecrated Sandals");
            AddItemToBoss(boss, "T3 - Desecrated Boots");
            AddItemToBoss(boss, "T3 - Desecrated Sabatons");
        }

        private void PopulateTheFourHorsemen()
        {
            Boss boss = AddBossToRaid("The Four Horsemen");
            AddItemToBoss(boss, "T3 - Desecrated Breastplate");
            AddItemToBoss(boss, "T3 - Desecrated Robe");
            AddItemToBoss(boss, "T3 - Desecrated Tunic");
            AddItemToBoss(boss, "Corrupted Ashbringer");
            AddItemToBoss(boss, "Leggings of Apocalypse");
            AddItemToBoss(boss, "Maul of the Redeemed Crusader");
            AddItemToBoss(boss, "Seal of the Damned");
            AddItemToBoss(boss, "Soulstring");
            AddItemToBoss(boss, "Warmth of Forgiveness");
        }

        private void PopulatePatchwerk()
        {
            Boss boss = AddBossToRaid("Patchwerk");
            AddItemToBoss(boss, "Cloak of Suturing");
            AddItemToBoss(boss, "Band of Reanimation");
            AddItemToBoss(boss, "Severance");
            AddItemToBoss(boss, "Wand of Fates");
            AddItemToBoss(boss, "The Plague Bearer");
        }

        private void PopulateGrobbulus()
        {
            Boss boss = AddBossToRaid("Grobbulus");
            AddItemToBoss(boss, "Icy Scale Spaulders");
            AddItemToBoss(boss, "Toxin Injector");
            AddItemToBoss(boss, "The End of Dreams");
            AddItemToBoss(boss, "Midnight Haze");
            AddItemToBoss(boss, "Glacial Mantle");
        }

        private void PopulatePatchwerkAndGrobbulus()
        {
            Boss boss = AddBossToRaid(@"Patchwerk / Grobbulus");
            AddItemToBoss(boss, "T3 - Desecrated Pauldrons");
            AddItemToBoss(boss, "T3 - Desecrated Shoulderpads");
            AddItemToBoss(boss, "T3 - Desecrated Spaulders");
        }

        private void PopulateGluth()
        {
            Boss boss = AddBossToRaid("Gluth");
            AddItemToBoss(boss, "Digested Hand of Power");
            AddItemToBoss(boss, "Rime Covered Mantle");
            AddItemToBoss(boss, "Claymore of Unholy Might");
            AddItemToBoss(boss, "Gluth's Missing Collar");
            AddItemToBoss(boss, "Death's Bargain");
        }

        private void PopulateThaddius()
        {
            Boss boss = AddBossToRaid("Thaddius");
            AddItemToBoss(boss, "T3 - Desecrated Helmet");
            AddItemToBoss(boss, "T3 - Desecrated Circlet");
            AddItemToBoss(boss, "T3 - Desecrated Headpiece");
            AddItemToBoss(boss, "Leggings of Polarity");
            AddItemToBoss(boss, "Spire of Twilight");
            AddItemToBoss(boss, "Eye of Diminution");
            AddItemToBoss(boss, "Plated Abomination Ribcage");
            AddItemToBoss(boss, "The Castigator");
        }

        private void PopulateSapphiron()
        {
            Boss boss = AddBossToRaid("Sapphiron");
            AddItemToBoss(boss, "Claw of the Frost Wyrm");
            AddItemToBoss(boss, "Cloak of the Necropolis");
            AddItemToBoss(boss, "Eye of the Dead");
            AddItemToBoss(boss, "Glyph of Deflection");
            AddItemToBoss(boss, "Might of the Scourge");
            AddItemToBoss(boss, "Resilience of the Scourge");
            AddItemToBoss(boss, "Power of the Scourge");
            AddItemToBoss(boss, "Sapphiron's Left Eye");
            AddItemToBoss(boss, "Sapphiron's Right Eye");
            AddItemToBoss(boss, "Shroud of Dominion");
            AddItemToBoss(boss, "Slayer's Crest");
            AddItemToBoss(boss, "The Face of Death");
            AddItemToBoss(boss, "The Restrained Essence of Sapphiron");
        }

        private void PopulateKelThuzad()
        {
            Boss boss = AddBossToRaid("Kel'Thuzad");
            AddItemToBoss(boss, "T3 - Ring");
            AddItemToBoss(boss, "Doomfinger");
            AddItemToBoss(boss, "Gem of Trapped Innocents");
            AddItemToBoss(boss, "Gressil, Dawn of Ruin");
            AddItemToBoss(boss, "Hammer of the Twisting Nether");
            AddItemToBoss(boss, "Kingsfall");
            AddItemToBoss(boss, "Might of Menethil");
            AddItemToBoss(boss, "Shield of Condemnation");
            AddItemToBoss(boss, "Soulseeker");
            AddItemToBoss(boss, "Stormrage's Talisman of Seething");
            AddItemToBoss(boss, "The Phylactery of Kel'Thuzad");
        }
    }
}

