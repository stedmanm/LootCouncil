using Microsoft.EntityFrameworkCore.Migrations;

namespace LootCouncil.Migrations
{
    public partial class NaxxMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 39L, "Thrash" },
                    { 58L, "Kel'Thuzad" },
                    { 57L, "Sapphiron" },
                    { 56L, "Thaddius" },
                    { 54L, "Patchwerk / Grobbulus" },
                    { 53L, "Grobbulus" },
                    { 52L, "Patchwerk" },
                    { 51L, "The Four Horsemen" },
                    { 50L, "Razuvious / Gothik" },
                    { 49L, "Gothik the Harvester" },
                    { 55L, "Gluth" },
                    { 47L, "Loatheb" },
                    { 46L, "Noth / Heigan" },
                    { 45L, "Heigan the Unclean" },
                    { 44L, "Noth the Plaguebringer" },
                    { 43L, "Maexxna" },
                    { 42L, "Anub'Rekhan / Faerlina" },
                    { 41L, "Grand Widow Faerlina" },
                    { 40L, "Anub'Rekhan" },
                    { 48L, "Instructor Razuvious" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 374L, "The Plague Bearer" },
                    { 375L, "Icy Scale Spaulders" },
                    { 376L, "Toxin Injector" },
                    { 377L, "The End of Dreams" },
                    { 378L, "Midnight Haze" },
                    { 379L, "Glacial Mantle" },
                    { 383L, "Digested Hand of Power" },
                    { 381L, "T3 - Desecrated Shoulderpads" },
                    { 382L, "T3 - Desecrated Spaulders" },
                    { 384L, "Rime Covered Mantle" },
                    { 385L, "Claymore of Unholy Might" },
                    { 373L, "Wand of Fates" },
                    { 380L, "T3 - Desecrated Pauldrons" },
                    { 372L, "Severance" },
                    { 362L, "T3 - Desecrated Robe" },
                    { 370L, "Cloak of Suturing" },
                    { 369L, "Warmth of Forgiveness" },
                    { 368L, "Soulstring" },
                    { 367L, "Seal of the Damned" },
                    { 366L, "Maul of the Redeemed Crusader" },
                    { 365L, "Leggings of Apocalypse" },
                    { 364L, "Corrupted Ashbringer" },
                    { 363L, "T3 - Desecrated Tunic" },
                    { 386L, "Gluth's Missing Collar" },
                    { 361L, "T3 - Desecrated Breastplate" },
                    { 360L, "T3 - Desecrated Sabatons" },
                    { 359L, "T3 - Desecrated Boots" },
                    { 358L, "T3 - Desecrated Sandals" },
                    { 357L, "The Soul Harvester's Bindings" },
                    { 371L, "Band of Reanimation" },
                    { 387L, "Death's Bargain" },
                    { 397L, "Cloak of the Necropolis" },
                    { 389L, "T3 - Desecrated Circlet" },
                    { 418L, "Stormrage's Talisman of Seething" },
                    { 417L, "Soulseeker" },
                    { 416L, "Shield of Condemnation" },
                    { 415L, "Might of Menethil" },
                    { 414L, "Kingsfall" },
                    { 413L, "Hammer of the Twisting Nether" },
                    { 412L, "Gressil, Dawn of Ruin" },
                    { 411L, "Gem of Trapped Innocents" },
                    { 410L, "Doomfinger" },
                    { 409L, "T3 - Ring" },
                    { 408L, "The Restrained Essence of Sapphiron" },
                    { 407L, "The Face of Death" },
                    { 406L, "Slayer's Crest" },
                    { 405L, "Shroud of Dominion" },
                    { 404L, "Sapphiron's Right Eye" },
                    { 403L, "Sapphiron's Left Eye" },
                    { 402L, "Power of the Scourge" },
                    { 401L, "Resilience of the Scourge" },
                    { 400L, "Might of the Scourge" },
                    { 399L, "Glyph of Deflection" },
                    { 398L, "Eye of the Dead" },
                    { 356L, "Sadist's Collar" },
                    { 396L, "Claw of the Frost Wyrm" },
                    { 395L, "The Castigator" },
                    { 394L, "Plated Abomination Ribcage" },
                    { 393L, "Eye of Diminution" },
                    { 392L, "Spire of Twilight" },
                    { 391L, "Leggings of Polarity" },
                    { 390L, "T3 - Desecrated Headpiece" },
                    { 388L, "T3 - Desecrated Helmet" },
                    { 355L, "Polar Helmet" },
                    { 345L, "Brimstone Staff" },
                    { 353L, "Boots of Displacement" },
                    { 319L, "T3 - Desecrated Handguards" },
                    { 318L, "T3 - Desecrated Gloves" },
                    { 317L, "T3 - Desecrated Gauntlets" },
                    { 316L, "Crystal Webbed Robe" },
                    { 315L, "T3 - Desecrated Wristguards" },
                    { 314L, "T3 - Desecrated Bracers" },
                    { 313L, "T3 - Desecrated Bindings" },
                    { 312L, "Widow's Remorse" },
                    { 311L, "The Widow's Embrace" },
                    { 310L, "Polar Shoulder Pads" },
                    { 309L, "Malice Stone Pendant" },
                    { 308L, "Icebane Pauldrons" },
                    { 307L, "Wristguards of Vengeance" },
                    { 306L, "Touch of Frost" },
                    { 305L, "Gem of Nerubis" },
                    { 304L, "Cryptfiend Silk Cloak" },
                    { 303L, "Band of Unanswered Prayers" },
                    { 302L, "Ring of the Eternal Flame" },
                    { 301L, "Stygian Buckler" },
                    { 300L, "Spaulders of the Grand Crusader" },
                    { 299L, "Pauldrons of Elemental Fury" },
                    { 298L, "Necro-Knight's Garb" },
                    { 297L, "Misplaced Servo Arm" },
                    { 296L, "Leggings of the Grand Crusader" },
                    { 295L, "Leggings of Elemental Fury" },
                    { 294L, "Harbinger of Doom" },
                    { 293L, "Girdle of Elemental Fury" },
                    { 292L, "Ghoul Skin Tunic" },
                    { 291L, "Belt of the Grand Crusader" },
                    { 320L, "Kiss of the Spider" },
                    { 354L, "Glacial Headdress" },
                    { 321L, "Maexxna's Fang" },
                    { 323L, "Wraith Blade" },
                    { 352L, "Iblis, Blade of the Fallen Seraph" },
                    { 351L, "Veil of Eclipse" },
                    { 350L, "Girdle of the Mentor" },
                    { 349L, "Idol of Longevity" },
                    { 348L, "Signet of the Fallen Defender" },
                    { 347L, "Wand of the Whispering Dead" },
                    { 346L, "Loatheb's Reflection" },
                    { 419L, "The Phylactery of Kel'Thuzad" },
                    { 344L, "Ring of Spiritual Fervor" },
                    { 343L, "The Eye of Nerub" },
                    { 342L, "Band of Unnatural Forces" },
                    { 341L, "T3 - Desecrated Legguards" },
                    { 340L, "T3 - Desecrated Leggings" },
                    { 339L, "T3 - Desecrated Legplates" },
                    { 338L, "T3 - Desecrated Girdle" },
                    { 337L, "T3 - Desecrated Belt" },
                    { 336L, "T3 - Desecrated Waistguard" },
                    { 335L, "Necklace of Necropsy" },
                    { 334L, "Icebane Helmet" },
                    { 333L, "Preceptor's Hat" },
                    { 332L, "Icy Scale Coif" },
                    { 331L, "Legplates of Carnage" },
                    { 330L, "Totem of Flowing Water" },
                    { 329L, "Libram of Light" },
                    { 328L, "Hatchet of Sundered Bone" },
                    { 327L, "Hailstone Band" },
                    { 326L, "Band of the Inevitable" },
                    { 325L, "Noth's Frigid Heart" },
                    { 324L, "Cloak of the Scourge" },
                    { 322L, "Pendant of Forgotten Names" }
                });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 4L, "Naxxramas", "Naxx" });

            migrationBuilder.InsertData(
                table: "BossHasItems",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 291L, 291L, 39L },
                    { 386L, 386L, 55L },
                    { 385L, 385L, 55L },
                    { 384L, 384L, 55L },
                    { 383L, 383L, 55L },
                    { 382L, 382L, 54L },
                    { 381L, 381L, 54L },
                    { 380L, 380L, 54L },
                    { 379L, 379L, 53L },
                    { 378L, 378L, 53L },
                    { 377L, 377L, 53L },
                    { 376L, 376L, 53L },
                    { 375L, 375L, 53L },
                    { 374L, 374L, 52L },
                    { 387L, 387L, 55L },
                    { 373L, 373L, 52L },
                    { 371L, 371L, 52L },
                    { 370L, 370L, 52L },
                    { 369L, 369L, 51L },
                    { 368L, 368L, 51L },
                    { 367L, 367L, 51L },
                    { 366L, 366L, 51L },
                    { 364L, 364L, 51L },
                    { 363L, 363L, 51L },
                    { 362L, 362L, 51L },
                    { 361L, 361L, 51L },
                    { 360L, 360L, 50L },
                    { 359L, 359L, 50L },
                    { 358L, 358L, 50L },
                    { 372L, 372L, 52L },
                    { 388L, 388L, 56L },
                    { 389L, 389L, 56L },
                    { 390L, 390L, 56L },
                    { 419L, 419L, 58L },
                    { 418L, 418L, 58L },
                    { 417L, 417L, 58L },
                    { 416L, 416L, 58L },
                    { 415L, 415L, 58L },
                    { 414L, 414L, 58L },
                    { 413L, 413L, 58L },
                    { 412L, 412L, 58L },
                    { 411L, 411L, 58L },
                    { 410L, 410L, 58L },
                    { 409L, 409L, 58L },
                    { 408L, 408L, 57L },
                    { 407L, 407L, 57L },
                    { 406L, 406L, 57L },
                    { 405L, 405L, 57L },
                    { 404L, 404L, 57L },
                    { 403L, 403L, 57L },
                    { 402L, 402L, 57L },
                    { 401L, 401L, 57L },
                    { 400L, 400L, 57L },
                    { 399L, 399L, 57L },
                    { 398L, 398L, 57L },
                    { 397L, 397L, 57L },
                    { 396L, 396L, 57L },
                    { 395L, 395L, 56L },
                    { 394L, 394L, 56L },
                    { 393L, 393L, 56L },
                    { 392L, 392L, 56L },
                    { 391L, 391L, 56L },
                    { 357L, 357L, 49L },
                    { 356L, 356L, 49L },
                    { 365L, 365L, 51L },
                    { 354L, 354L, 49L },
                    { 320L, 320L, 43L },
                    { 319L, 319L, 43L },
                    { 318L, 318L, 43L },
                    { 317L, 317L, 43L },
                    { 316L, 316L, 43L },
                    { 315L, 315L, 42L },
                    { 355L, 355L, 49L },
                    { 313L, 313L, 42L },
                    { 312L, 312L, 41L },
                    { 311L, 311L, 41L },
                    { 310L, 310L, 41L },
                    { 309L, 309L, 41L },
                    { 308L, 308L, 41L },
                    { 307L, 307L, 40L },
                    { 306L, 306L, 40L },
                    { 305L, 305L, 40L },
                    { 304L, 304L, 40L },
                    { 303L, 303L, 40L },
                    { 302L, 302L, 39L },
                    { 301L, 301L, 39L },
                    { 300L, 300L, 39L },
                    { 299L, 299L, 39L },
                    { 298L, 298L, 39L },
                    { 297L, 297L, 39L },
                    { 296L, 296L, 39L },
                    { 295L, 295L, 39L },
                    { 294L, 294L, 39L },
                    { 293L, 293L, 39L },
                    { 292L, 292L, 39L },
                    { 321L, 321L, 43L },
                    { 322L, 322L, 43L },
                    { 314L, 314L, 42L },
                    { 324L, 324L, 44L },
                    { 353L, 353L, 49L },
                    { 352L, 352L, 48L },
                    { 351L, 351L, 48L },
                    { 350L, 350L, 48L },
                    { 349L, 349L, 48L },
                    { 323L, 323L, 43L },
                    { 347L, 347L, 48L },
                    { 346L, 346L, 47L },
                    { 345L, 345L, 47L },
                    { 344L, 344L, 47L },
                    { 343L, 343L, 47L },
                    { 342L, 342L, 47L },
                    { 341L, 341L, 47L },
                    { 340L, 340L, 47L },
                    { 348L, 348L, 48L },
                    { 338L, 338L, 46L },
                    { 339L, 339L, 47L },
                    { 325L, 325L, 44L },
                    { 326L, 326L, 44L },
                    { 327L, 327L, 44L },
                    { 329L, 329L, 44L },
                    { 330L, 330L, 44L },
                    { 331L, 331L, 45L },
                    { 328L, 328L, 44L },
                    { 333L, 333L, 45L },
                    { 334L, 334L, 45L },
                    { 335L, 335L, 45L },
                    { 336L, 336L, 46L },
                    { 337L, 337L, 46L },
                    { 332L, 332L, 45L }
                });

            migrationBuilder.InsertData(
                table: "RaidHasBosses",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 56L, 56L, 4L },
                    { 49L, 49L, 4L },
                    { 55L, 55L, 4L },
                    { 54L, 54L, 4L },
                    { 53L, 53L, 4L },
                    { 52L, 52L, 4L },
                    { 51L, 51L, 4L },
                    { 50L, 50L, 4L },
                    { 48L, 48L, 4L },
                    { 41L, 41L, 4L },
                    { 46L, 46L, 4L },
                    { 45L, 45L, 4L },
                    { 44L, 44L, 4L },
                    { 43L, 43L, 4L },
                    { 42L, 42L, 4L },
                    { 40L, 40L, 4L },
                    { 39L, 39L, 4L },
                    { 57L, 57L, 4L },
                    { 47L, 47L, 4L },
                    { 58L, 58L, 4L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
