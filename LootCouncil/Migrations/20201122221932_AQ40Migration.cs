using Microsoft.EntityFrameworkCore.Migrations;

namespace LootCouncil.Migrations
{
    public partial class AQ40Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 23L, "Thrash" },
                    { 38L, "C'Thun" },
                    { 36L, "Vek'lor's" },
                    { 35L, "Vek'nilash's" },
                    { 34L, "Princess Huhuran" },
                    { 33L, "Viscidus" },
                    { 32L, "Viscidus / Huhuran" },
                    { 31L, "Fankriss" },
                    { 37L, "Ouro" },
                    { 29L, "Bug Trio" },
                    { 28L, "Vem" },
                    { 27L, "Kri" },
                    { 26L, "Yauj" },
                    { 25L, "Prophet Skeram" },
                    { 24L, "Shared" },
                    { 30L, "Battleguard Sartura" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 248L, "Gloves of the Messiah" },
                    { 249L, "Hive Defiler Wristguards" },
                    { 250L, "Huhuran's Stinger" },
                    { 251L, "Ring of the Martyr" },
                    { 252L, "Wasphide Gauntlets" },
                    { 256L, "Gloves of the Hidden Temple" },
                    { 254L, "Belt of the Fallen Emperor" },
                    { 255L, "Bracelets of Royal Redemption" },
                    { 257L, "Grasp of the Fallen Emperor" },
                    { 258L, "Kalimdor's Revenge" },
                    { 247L, "Cloak of the Golden Hive" },
                    { 253L, "Amulet of Vek'nilash" },
                    { 246L, "Slime-coated Leggings" },
                    { 238L, "Totem of Life" },
                    { 244L, "Scarab Brooch" },
                    { 243L, "Ring of the Qiraji Fury" },
                    { 242L, "Idol of Health" },
                    { 241L, "Gauntlets of Kalimdor" },
                    { 240L, "T2.5 - Qiraji Bindings of Dominance" },
                    { 239L, "T2.5 - Qiraji Bindings of Command" },
                    { 259L, "T2.5 - Vek'nilash's Circlet" },
                    { 237L, "Silithid Carapace Chestguard" },
                    { 236L, "Scaled Sand Reaver Leggings" },
                    { 235L, "Robes of the Guardian Saint" },
                    { 234L, "Pauldrons of the Unrelenting" },
                    { 233L, "Mantle of Wicked Revenge" },
                    { 245L, "Sharpened Silithid Femur" },
                    { 260L, "Boots of Epiphany" },
                    { 268L, "Don Rigoberto's Lost Hat" },
                    { 262L, "Ring of Emperor Vek'lor" },
                    { 289L, "Scepter of the False Prophet" },
                    { 288L, "Ring of the Godslayer" },
                    { 287L, "Mark of C'Thun" },
                    { 286L, "T2.5 - Husk of the Old God" },
                    { 285L, "Grasp of the Old God" },
                    { 284L, "Gauntlets of Annihilation" },
                    { 283L, "Eyestalk Waist Cord" },
                    { 282L, "Eye of C'Thun" },
                    { 281L, "Death's Sting" },
                    { 280L, "Dark Storm Gauntlets" },
                    { 279L, "Dark Edge of Insanity" },
                    { 278L, "Cloak of the Devoured" },
                    { 277L, "Cloak of Clarity" },
                    { 276L, "T2.5 - Carapace of the Old God" },
                    { 275L, "Belt of Never-ending Agony" },
                    { 274L, "Wormscale Blocker" },
                    { 273L, "The Burrower's Shell" },
                    { 272L, "T2.5 - Skin of the Great Sandworm" },
                    { 271L, "T2.5 - Ouro's Intact Hide" },
                    { 270L, "Larvae of the Great Worm" },
                    { 269L, "Jom Gabbar" },
                    { 232L, "Libram of Grace" },
                    { 267L, "Burrower Bracers" },
                    { 266L, "Vek'lor's Gloves of Devastation" },
                    { 265L, "T2.5 - Vek'lor's Diadem" },
                    { 264L, "Royal Scepter of Vek'lor" },
                    { 263L, "Royal Qiraji Belt" },
                    { 261L, "Qiraji Execution Bracers" },
                    { 231L, "Hive Tunneler's Boots" },
                    { 223L, "Gauntlets of Steadfast Determination" },
                    { 229L, "Cloak of Untold Secrets" },
                    { 197L, "Mantle of the Desert Crusade" },
                    { 196L, "Mantle of the Desert's Fury" },
                    { 195L, "Bile-Covered Gauntlets" },
                    { 194L, "Mantle of Phrenic Power" },
                    { 193L, "Hammer of Ji'zhi" },
                    { 192L, "Staff of the Qiraji Prophets" },
                    { 191L, "Ring of Swarming Thought" },
                    { 190L, "Boots of the Unwavering Will" },
                    { 189L, "Boots of the Redeemed Prophecy" },
                    { 188L, "Breastplate of Annihilation" },
                    { 187L, "Barrage Shoulders" },
                    { 186L, "Boots of the Fallen Prophet" },
                    { 198L, "Ukko's Ring of Darkness" },
                    { 185L, "Beetle Scaled Wristguards" },
                    { 183L, "Cloak of Concentrated Hatred" },
                    { 182L, "Pendant of the Qiraji Guardian" },
                    { 181L, "Amulet of Foul Warding" },
                    { 180L, "Imperial Qiraji Regalia" },
                    { 179L, "Imperial Qiraji Armaments" },
                    { 178L, "Shard of the Fallen Star" },
                    { 177L, "Ritssyn's Ring of Chaos" },
                    { 176L, "Neretzek, The Blood Drinker" },
                    { 175L, "Gloves of the Redeemed Prophecy" },
                    { 174L, "Gloves of the Immortal" },
                    { 173L, "Garb of Royal Ascension" },
                    { 172L, "Anubisath Warhammer" },
                    { 184L, "Leggings of Immersion" },
                    { 199L, "Vest of Swift Execution" },
                    { 200L, "Ring of the Devoured" },
                    { 201L, "Petrified Scarab" },
                    { 228L, "Barbed Choker" },
                    { 227L, "Barb of the Sand Reaver" },
                    { 226L, "Ancient Qiraji Ripper" },
                    { 225L, "Badge of the Swarmguard" },
                    { 224L, "Legplates of Blazing Light" },
                    { 290L, "Vanquished Tentacle of C'Thun" },
                    { 222L, "Sartura's Might" },
                    { 221L, "Scaled Leggings of Qiraji Fury" },
                    { 220L, "Gloves of Enforcement" },
                    { 219L, "Creeping Vine Helm" },
                    { 218L, "Thick Qirajihide Belt" },
                    { 217L, "Silithid Claw" },
                    { 216L, "Robes of the Battleguard" },
                    { 215L, "Recomposed Boots" },
                    { 214L, "Leggings of the Festering Swarm" },
                    { 213L, "Necklace of Purity" },
                    { 212L, "Angelista's Touch" },
                    { 211L, "Triad Girdle" },
                    { 210L, "Guise of the Devourer" },
                    { 209L, "Ternary Mantle" },
                    { 208L, "Robes of the Triumvirate" },
                    { 207L, "Cape of the Trinity" },
                    { 206L, "Angelista's Charm" },
                    { 205L, "Boots of the Fallen Hero" },
                    { 204L, "Ooze-ridden Gauntlets" },
                    { 203L, "Gloves of Ebru" },
                    { 202L, "Wand of Qiraji Nobility" },
                    { 230L, "Fetish of the Sand Reaver" }
                });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 3L, "The Temple of Ahn'Qiraj", "AQ40" });

            migrationBuilder.InsertData(
                table: "BossHasItems",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 172L, 172L, 23L },
                    { 260L, 260L, 36L },
                    { 259L, 259L, 35L },
                    { 258L, 258L, 35L },
                    { 257L, 257L, 35L },
                    { 256L, 256L, 35L },
                    { 255L, 255L, 35L },
                    { 254L, 254L, 35L },
                    { 253L, 253L, 35L },
                    { 252L, 252L, 34L },
                    { 251L, 251L, 34L },
                    { 250L, 250L, 34L },
                    { 249L, 249L, 34L },
                    { 261L, 261L, 36L },
                    { 248L, 248L, 34L },
                    { 246L, 246L, 33L },
                    { 245L, 245L, 33L },
                    { 244L, 244L, 33L },
                    { 243L, 243L, 33L },
                    { 242L, 242L, 33L },
                    { 241L, 241L, 33L },
                    { 240L, 240L, 32L },
                    { 238L, 238L, 31L },
                    { 237L, 237L, 31L },
                    { 236L, 236L, 31L },
                    { 235L, 235L, 31L },
                    { 234L, 234L, 31L },
                    { 247L, 247L, 34L },
                    { 233L, 233L, 31L },
                    { 262L, 262L, 36L },
                    { 264L, 264L, 36L },
                    { 290L, 290L, 38L },
                    { 289L, 289L, 38L },
                    { 288L, 288L, 38L },
                    { 287L, 287L, 38L },
                    { 286L, 286L, 38L },
                    { 285L, 285L, 38L },
                    { 284L, 284L, 38L },
                    { 283L, 283L, 38L },
                    { 282L, 282L, 38L },
                    { 281L, 281L, 38L },
                    { 280L, 280L, 38L },
                    { 279L, 279L, 38L },
                    { 263L, 263L, 36L },
                    { 278L, 278L, 38L },
                    { 276L, 276L, 38L },
                    { 275L, 275L, 38L },
                    { 274L, 274L, 37L },
                    { 273L, 273L, 37L },
                    { 272L, 272L, 37L },
                    { 271L, 271L, 37L },
                    { 270L, 270L, 37L },
                    { 269L, 269L, 37L },
                    { 268L, 268L, 37L },
                    { 267L, 267L, 37L },
                    { 266L, 266L, 36L },
                    { 265L, 265L, 36L },
                    { 277L, 277L, 38L },
                    { 232L, 232L, 31L },
                    { 239L, 239L, 32L },
                    { 230L, 230L, 31L },
                    { 199L, 199L, 27L },
                    { 198L, 198L, 26L },
                    { 197L, 197L, 26L },
                    { 196L, 196L, 26L },
                    { 195L, 195L, 26L },
                    { 231L, 231L, 31L },
                    { 193L, 193L, 25L },
                    { 192L, 192L, 25L },
                    { 191L, 191L, 25L },
                    { 190L, 190L, 25L },
                    { 189L, 189L, 25L },
                    { 188L, 188L, 25L },
                    { 187L, 187L, 25L },
                    { 186L, 186L, 25L },
                    { 185L, 185L, 25L },
                    { 184L, 184L, 25L },
                    { 183L, 183L, 25L },
                    { 182L, 182L, 25L },
                    { 181L, 181L, 25L },
                    { 180L, 180L, 24L },
                    { 179L, 179L, 24L },
                    { 178L, 178L, 23L },
                    { 177L, 177L, 23L },
                    { 176L, 176L, 23L },
                    { 175L, 175L, 23L },
                    { 174L, 174L, 23L },
                    { 173L, 173L, 23L },
                    { 200L, 200L, 27L },
                    { 201L, 201L, 27L },
                    { 194L, 194L, 26L },
                    { 203L, 203L, 28L },
                    { 229L, 229L, 31L },
                    { 228L, 228L, 31L },
                    { 227L, 227L, 31L },
                    { 226L, 226L, 31L },
                    { 225L, 225L, 30L },
                    { 224L, 224L, 30L },
                    { 202L, 202L, 27L },
                    { 223L, 223L, 30L },
                    { 222L, 222L, 30L },
                    { 221L, 221L, 30L },
                    { 219L, 219L, 30L },
                    { 218L, 218L, 30L },
                    { 217L, 217L, 30L },
                    { 220L, 220L, 30L },
                    { 215L, 215L, 30L },
                    { 204L, 204L, 28L },
                    { 205L, 205L, 28L },
                    { 206L, 206L, 28L },
                    { 216L, 216L, 30L },
                    { 208L, 208L, 29L },
                    { 209L, 209L, 29L },
                    { 207L, 207L, 29L },
                    { 211L, 211L, 29L },
                    { 212L, 212L, 29L },
                    { 213L, 213L, 30L },
                    { 214L, 214L, 30L },
                    { 210L, 210L, 29L }
                });

            migrationBuilder.InsertData(
                table: "RaidHasBosses",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 31L, 31L, 3L },
                    { 36L, 36L, 3L },
                    { 35L, 35L, 3L },
                    { 34L, 34L, 3L },
                    { 33L, 33L, 3L },
                    { 32L, 32L, 3L },
                    { 30L, 30L, 3L },
                    { 37L, 37L, 3L },
                    { 28L, 28L, 3L },
                    { 27L, 27L, 3L },
                    { 26L, 26L, 3L },
                    { 25L, 25L, 3L },
                    { 24L, 24L, 3L },
                    { 23L, 23L, 3L },
                    { 29L, 29L, 3L },
                    { 38L, 38L, 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "BossHasItems",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "RaidHasBosses",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
