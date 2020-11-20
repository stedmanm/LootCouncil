using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LootCouncil.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 12, nullable: false),
                    Class = table.Column<int>(nullable: false),
                    Race = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Faction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raids",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ShortName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaidTeams",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    GuildId = table.Column<long>(nullable: false),
                    DisplayName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildHasCharacters",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<long>(nullable: false),
                    ChildId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildHasCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuildHasCharacters_Characters_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildHasCharacters_Guilds_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BossHasItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<long>(nullable: false),
                    ChildId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BossHasItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BossHasItems_Items_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BossHasItems_Bosses_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Bosses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPriorities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ItemId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPriorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPriorities_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loots",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterId = table.Column<long>(nullable: false),
                    ItemId = table.Column<long>(nullable: false),
                    ItemNeedReason = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loots_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loots_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaidHasBosses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<long>(nullable: false),
                    ChildId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidHasBosses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaidHasBosses_Bosses_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Bosses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaidHasBosses_Raids_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Raids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildHasRaidTeams",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<long>(nullable: false),
                    ChildId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildHasRaidTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuildHasRaidTeams_RaidTeams_ChildId",
                        column: x => x.ChildId,
                        principalTable: "RaidTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildHasRaidTeams_Guilds_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaidEvents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RaidTeamId = table.Column<long>(nullable: false),
                    RaidId = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaidEvents_Raids_RaidId",
                        column: x => x.RaidId,
                        principalTable: "Raids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaidEvents_RaidTeams_RaidTeamId",
                        column: x => x.RaidTeamId,
                        principalTable: "RaidTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterPriorities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemPriorityId = table.Column<long>(nullable: false),
                    CharacterId = table.Column<long>(nullable: false),
                    Priority = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterPriorities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterPriorities_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterPriorities_ItemPriorities_ItemPriorityId",
                        column: x => x.ItemPriorityId,
                        principalTable: "ItemPriorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaidEventHasLoots",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<long>(nullable: false),
                    ChildId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidEventHasLoots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaidEventHasLoots_Loots_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Loots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaidEventHasLoots_RaidEvents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "RaidEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f166a50a-287d-42c3-af06-f7e42977fc7c", "057b3554-e749-4c52-859f-7732c36856d0", "Admin", "ADMIN" },
                    { "c6965c4a-787c-4cfc-a27e-874ac926e3dc", "909231bd-a7ba-4b0e-9762-dae4dbd94822", "Member", "MEMBER" },
                    { "8cb63961-5d08-498d-9c67-ea4f9ff36ea6", "9cdae67b-ac2d-4a25-a5f8-0dcca7c9de6f", "GuildMaster", "GUILDMASTER" }
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 22L, "Nefarian" },
                    { 21L, "Chromaggus" },
                    { 20L, "Flamegor" },
                    { 19L, "Ebonroc" },
                    { 18L, "Firemaw" },
                    { 17L, "Drakes" },
                    { 16L, "Broodlord" },
                    { 15L, "Vaelastrasz" },
                    { 14L, "Razorgore" },
                    { 1L, "Thrash" },
                    { 12L, "Ragnaros" },
                    { 13L, "Thrash" },
                    { 3L, "Lucifron" },
                    { 4L, "Magmadar" },
                    { 5L, "Gehennas" },
                    { 6L, "Garr" },
                    { 2L, "Shared" },
                    { 8L, "Shazzrah" },
                    { 9L, "Sulfuron Harbinger" },
                    { 10L, "Golemagg" },
                    { 11L, "Majordomo Executus" },
                    { 7L, "Baron Geddon" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 111L, "T2 - Boots" },
                    { 112L, "Lifegiving Gem" },
                    { 113L, "Venomous Totem" },
                    { 114L, "Black Brood Pauldrons" },
                    { 115L, "Bracers of Arcane Accuracy" },
                    { 116L, "Heartstriker" },
                    { 117L, "Maladath" },
                    { 118L, "Taut Dragonhide Belt" },
                    { 123L, "Drake Talon Cleaver" },
                    { 120L, "Ring of Blackrock" },
                    { 121L, "Rejuvenating Gem" },
                    { 122L, "Shadow Wing Focus Staff" },
                    { 110L, "Red Dragonscale Protector" },
                    { 124L, "Scrolls of Blinding Light" },
                    { 125L, "Natural Alignment Crystal" },
                    { 126L, "Black Ash Robe" },
                    { 127L, "Firemaw's Clutch" },
                    { 119L, "Drake Talon Pauldrons" },
                    { 109L, "Dragonfang Blade" },
                    { 103L, "The Untamed Blade" },
                    { 107L, "Pendant of the Fallen Dragon" },
                    { 90L, "Spinal Reaper" },
                    { 91L, "Cloak of Draconic Might" },
                    { 92L, "Boots of Pure Thought" },
                    { 93L, "Draconic Maul" },
                    { 94L, "Doom's Edge" },
                    { 95L, "Band of Dark Dominion" },
                    { 96L, "Essence Gatherer" },
                    { 97L, "T2 - Wrists" },
                    { 98L, "Arcane Infused Gem" },
                    { 99L, "The Black Book" },
                    { 100L, "Gloves of Rapid Evolution" },
                    { 101L, "Mantle of the Blackwing Cabal" },
                    { 102L, "Spineshatter" },
                    { 128L, "Claw of the Black Drake" },
                    { 104L, "T2 - Belt" },
                    { 105L, "Mind Quickening Gem" },
                    { 106L, "Rune of Metamorphosis" },
                    { 108L, "Helm of Endless Rage" },
                    { 129L, "Cloak of Firemaw" },
                    { 134L, "Drake Fang Talisman" },
                    { 131L, "Primalist's Linked Legguards" },
                    { 154L, "Claw of Chromaggus" },
                    { 155L, "Primalist's Linked Waistguard" },
                    { 156L, "Ashjre'thul, Crossbow of Smiting" },
                    { 157L, "Elementium Reinforced Bulwark" },
                    { 158L, "T2 - Chest" },
                    { 159L, "Head of Nefarian" },
                    { 160L, "Cloak of the Brood Lord" },
                    { 161L, "Boots of the Shadow Flame" },
                    { 153L, "Chromatically Tempered Sword" },
                    { 162L, "Therazane's Link" },
                    { 164L, "Neltharion's Tear" },
                    { 165L, "Pure Elementium Band" },
                    { 166L, "Mish'undare, Circlet of the Mind Flayer" },
                    { 167L, "Prestor's Talisman of Connivery" },
                    { 168L, "Staff of the Shadow Flame" },
                    { 169L, "Ashkandi, Greatsword of the Brotherhood" },
                    { 170L, "Crul'shorukh, Edge of Chaos" },
                    { 171L, "Lok'amir il Romathis" },
                    { 163L, "Archimtiros' Ring of Reckoning" },
                    { 130L, "Legguards of the Fallen Crusader" },
                    { 152L, "Empowered Leggings" },
                    { 150L, "Elementium Threaded Cloak" },
                    { 132L, "Aegis of Preservation" },
                    { 133L, "Band of Forced Concentration" },
                    { 89L, "Shard of the Flame" },
                    { 135L, "Ebony Flame Gloves" },
                    { 136L, "Malfurion's Blessed Bulwark" },
                    { 137L, "Dragonbreath Hand Cannon" },
                    { 138L, "Shroud of Pure Thought" },
                    { 139L, "Circle of Applied Force" },
                    { 151L, "Girdle of the Fallen Crusader" },
                    { 140L, "Emberweave Leggings" },
                    { 142L, "Dragon's Touch" },
                    { 143L, "Herald of Woe" },
                    { 144L, "T2 - Shoulders" },
                    { 145L, "Angelista's Grasp" },
                    { 146L, "Taut Dragonhide Shoulderpads" },
                    { 147L, "Chromatic Boots" },
                    { 148L, "Taut Dragonhide Gloves" },
                    { 149L, "Shimmering Geta" },
                    { 141L, "Styleen's Impeding Scarab" },
                    { 88L, "Perdition's Blade" },
                    { 84L, "Dragon's Blood Cape" },
                    { 86L, "Malistar's Defender" },
                    { 23L, "T1 - Cenarion Boots" },
                    { 24L, "T1 - Felheart Gloves" },
                    { 25L, "T1 - Lawbringer Boots" },
                    { 26L, "T1 - Gauntlets of Might" },
                    { 27L, "T1 - Earthfury Boots" },
                    { 28L, "T1 - Legs" },
                    { 29L, "Earthshaker" },
                    { 30L, "Eskhandar's Right Claw" },
                    { 31L, "Medallion of Steadfast Might" },
                    { 32L, "Striker's Mark" },
                    { 33L, "T1 - Earthfury Gauntlets" },
                    { 34L, "T1 - Giantstalker's Boots" },
                    { 35L, "T1 - Gloves of Prophecy" },
                    { 36L, "T1 - Lawbringer Gauntlets" },
                    { 37L, "T1 - Nightslayer Gloves" },
                    { 38L, "T1 - Sabatons of Might" },
                    { 39L, "T1 - Helm" },
                    { 22L, "Choker of Enlightenment" },
                    { 21L, "Sorcerous Dagger" },
                    { 20L, "Crimson Shocker" },
                    { 19L, "Quick Strike Ring" },
                    { 1L, "T1 - Belt" },
                    { 2L, "T1 - Bracers" },
                    { 3L, "Robe of Volatile Power" },
                    { 4L, "Flamewaker Legplates" },
                    { 5L, "Ring of Spell Power" },
                    { 6L, "Heavy Dark Iron Ring" },
                    { 7L, "Manastorm Leggings" },
                    { 8L, "Salamander Scale Pants" },
                    { 40L, "Aurastone Hammer" },
                    { 9L, "Wristguards of Stability" },
                    { 11L, "Magma Tempered Boots" },
                    { 12L, "Talisman of Ephemeral Power" },
                    { 13L, "Mana Igniting Cord" },
                    { 14L, "Aged Core Leather Gloves" },
                    { 15L, "Deep Earth Spaulders" },
                    { 16L, "Fire Runed Grimoire" },
                    { 17L, "Flameguard Gauntlets" },
                    { 18L, "Obsidian Edged Blade" },
                    { 10L, "Sabatons of the Flamewalker" },
                    { 87L, "Onslaught Girdle" },
                    { 41L, "Brutality Blade" },
                    { 43L, "Gutgore Ripper" },
                    { 66L, "Cauterizing Band" },
                    { 67L, "Core Forged Greaves" },
                    { 68L, "Core Hound Tooth" },
                    { 69L, "Finkle's Lava Dredger" },
                    { 70L, "Fireguard Shoulders" },
                    { 71L, "Fireproof Cloak" },
                    { 72L, "Gloves of the Hypnotic Flame" },
                    { 73L, "Sash of Whispered Secrets" },
                    { 42L, "Drillborer Disk" },
                    { 74L, "The Eye of Divinity" },
                    { 76L, "Wristguards of True Flight" },
                    { 78L, "Band of Accuria" },
                    { 79L, "Band of Sulfuras" },
                    { 80L, "Bonereaver's Edge" },
                    { 81L, "Choker of the Fire Lord" },
                    { 82L, "Cloak of the Shrouded Mists" },
                    { 83L, "Crown of Destruction" },
                    { 85L, "Essence of the Pure Flame" },
                    { 75L, "Wild Growth Spaulders" },
                    { 64L, "Staff of Dominance" },
                    { 65L, "Ancient Petrified Leaf" },
                    { 62L, "Azuresong Mageblade" },
                    { 44L, "T1 - Arcanist Mantle" },
                    { 45L, "T1 - Cenarion Spaulders" },
                    { 46L, "T1 - Earthfury Epaulets" },
                    { 47L, "T1 - Felheart Shoulder Pads" },
                    { 48L, "T1 - Lawbringer Spaulders" },
                    { 49L, "T1 - Seal of the Archmagus" },
                    { 50L, "T1 - Arcanist Gloves" },
                    { 63L, "Blastershot Launcher" },
                    { 52L, "T1 - Giantstalker's Gloves" },
                    { 51L, "T1 - Cenarion Gloves" },
                    { 54L, "T1 - Boots of Prophecy" },
                    { 55L, "T1 - Nightslayer Boots" },
                    { 56L, "T1 - Giantstalker's Epaulets" },
                    { 57L, "T1 - Mantle of Prophecy" },
                    { 58L, "T1 - Nightslayer Shoulder Pads" },
                    { 59L, "T1 - Pauldrons of Might" },
                    { 60L, "Shadowstrike" },
                    { 61L, "T1 - Chest" },
                    { 53L, "T1 - Felheart Slippers" },
                    { 77L, "T2 - Legs" }
                });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1L, "Molten Core", "MC" },
                    { 2L, "Blackwing Lair", "BWL" }
                });

            migrationBuilder.InsertData(
                table: "BossHasItems",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 112L, 112L, 16L },
                    { 113L, 113L, 16L },
                    { 114L, 114L, 16L },
                    { 115L, 115L, 16L },
                    { 116L, 116L, 16L },
                    { 117L, 117L, 16L },
                    { 118L, 118L, 17L },
                    { 119L, 119L, 17L },
                    { 120L, 120L, 17L },
                    { 121L, 121L, 17L },
                    { 122L, 122L, 17L },
                    { 123L, 123L, 17L },
                    { 124L, 124L, 18L },
                    { 125L, 125L, 18L },
                    { 126L, 126L, 18L },
                    { 127L, 127L, 18L },
                    { 128L, 128L, 18L },
                    { 111L, 111L, 16L },
                    { 110L, 110L, 15L },
                    { 109L, 109L, 15L },
                    { 108L, 108L, 15L },
                    { 89L, 89L, 12L },
                    { 90L, 90L, 12L },
                    { 91L, 91L, 13L },
                    { 92L, 92L, 13L },
                    { 93L, 93L, 13L },
                    { 94L, 94L, 13L },
                    { 95L, 95L, 13L },
                    { 96L, 96L, 13L },
                    { 129L, 129L, 18L },
                    { 98L, 98L, 14L },
                    { 100L, 100L, 14L },
                    { 101L, 101L, 14L },
                    { 102L, 102L, 14L },
                    { 103L, 103L, 14L },
                    { 104L, 104L, 15L },
                    { 105L, 105L, 15L },
                    { 106L, 106L, 15L },
                    { 107L, 107L, 15L },
                    { 99L, 99L, 14L },
                    { 88L, 88L, 12L },
                    { 130L, 130L, 18L },
                    { 132L, 132L, 19L },
                    { 155L, 155L, 21L },
                    { 156L, 156L, 21L },
                    { 157L, 157L, 21L },
                    { 158L, 158L, 22L },
                    { 159L, 159L, 22L },
                    { 160L, 160L, 22L },
                    { 161L, 161L, 22L },
                    { 162L, 162L, 22L },
                    { 163L, 163L, 22L },
                    { 164L, 164L, 22L },
                    { 165L, 165L, 22L },
                    { 166L, 166L, 22L },
                    { 167L, 167L, 22L },
                    { 168L, 168L, 22L },
                    { 169L, 169L, 22L },
                    { 170L, 170L, 22L },
                    { 171L, 171L, 22L },
                    { 154L, 154L, 21L },
                    { 153L, 153L, 21L },
                    { 152L, 152L, 21L },
                    { 151L, 151L, 21L },
                    { 133L, 133L, 19L },
                    { 134L, 134L, 19L },
                    { 135L, 135L, 19L },
                    { 136L, 136L, 19L },
                    { 137L, 137L, 19L },
                    { 138L, 138L, 20L },
                    { 139L, 139L, 20L },
                    { 140L, 140L, 20L },
                    { 131L, 131L, 18L },
                    { 141L, 141L, 20L },
                    { 143L, 143L, 20L },
                    { 144L, 144L, 21L },
                    { 145L, 145L, 21L },
                    { 146L, 146L, 21L },
                    { 147L, 147L, 21L },
                    { 148L, 148L, 21L },
                    { 149L, 149L, 21L },
                    { 150L, 150L, 21L },
                    { 142L, 142L, 20L },
                    { 87L, 87L, 12L },
                    { 97L, 97L, 14L },
                    { 85L, 85L, 12L },
                    { 24L, 24L, 3L },
                    { 25L, 25L, 3L },
                    { 26L, 26L, 3L },
                    { 27L, 27L, 3L },
                    { 28L, 28L, 4L },
                    { 29L, 29L, 4L },
                    { 30L, 30L, 4L },
                    { 31L, 31L, 4L },
                    { 23L, 23L, 3L },
                    { 32L, 32L, 4L },
                    { 34L, 34L, 5L },
                    { 35L, 35L, 5L },
                    { 36L, 36L, 5L },
                    { 37L, 37L, 5L },
                    { 38L, 38L, 5L },
                    { 39L, 39L, 6L },
                    { 40L, 40L, 6L },
                    { 41L, 41L, 6L },
                    { 86L, 86L, 12L },
                    { 42L, 42L, 6L },
                    { 22L, 22L, 3L },
                    { 20L, 20L, 2L },
                    { 2L, 2L, 1L },
                    { 3L, 3L, 2L },
                    { 4L, 4L, 2L },
                    { 5L, 5L, 2L },
                    { 6L, 6L, 2L },
                    { 7L, 7L, 2L },
                    { 8L, 8L, 2L },
                    { 9L, 9L, 2L },
                    { 21L, 21L, 2L },
                    { 10L, 10L, 2L },
                    { 12L, 12L, 2L },
                    { 13L, 13L, 2L },
                    { 14L, 14L, 2L },
                    { 15L, 15L, 2L },
                    { 16L, 16L, 2L },
                    { 17L, 17L, 2L },
                    { 18L, 18L, 2L },
                    { 19L, 19L, 2L },
                    { 11L, 11L, 2L },
                    { 43L, 43L, 6L },
                    { 33L, 33L, 5L },
                    { 45L, 45L, 7L },
                    { 68L, 68L, 11L },
                    { 69L, 69L, 11L },
                    { 71L, 71L, 11L },
                    { 72L, 72L, 11L },
                    { 73L, 73L, 11L },
                    { 74L, 74L, 11L },
                    { 75L, 75L, 11L },
                    { 44L, 44L, 7L },
                    { 76L, 76L, 11L },
                    { 77L, 77L, 12L },
                    { 78L, 78L, 12L },
                    { 79L, 79L, 12L },
                    { 80L, 80L, 12L },
                    { 81L, 81L, 12L },
                    { 82L, 82L, 12L },
                    { 83L, 83L, 12L },
                    { 84L, 84L, 12L },
                    { 67L, 67L, 11L },
                    { 66L, 66L, 11L },
                    { 70L, 70L, 11L },
                    { 64L, 64L, 10L },
                    { 46L, 46L, 7L },
                    { 47L, 47L, 7L },
                    { 48L, 48L, 7L },
                    { 49L, 49L, 7L },
                    { 50L, 50L, 8L },
                    { 65L, 65L, 11L },
                    { 52L, 52L, 8L },
                    { 53L, 53L, 8L },
                    { 54L, 54L, 8L },
                    { 51L, 51L, 8L },
                    { 56L, 56L, 9L },
                    { 57L, 57L, 9L },
                    { 58L, 58L, 9L },
                    { 59L, 59L, 9L },
                    { 60L, 60L, 9L },
                    { 61L, 61L, 10L },
                    { 62L, 62L, 10L },
                    { 63L, 63L, 10L },
                    { 55L, 55L, 8L }
                });

            migrationBuilder.InsertData(
                table: "RaidHasBosses",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 13L, 13L, 2L },
                    { 14L, 14L, 2L },
                    { 15L, 15L, 2L },
                    { 16L, 16L, 2L },
                    { 20L, 20L, 2L },
                    { 18L, 18L, 2L },
                    { 19L, 19L, 2L },
                    { 12L, 12L, 1L },
                    { 17L, 17L, 2L },
                    { 11L, 11L, 1L },
                    { 21L, 21L, 2L },
                    { 9L, 9L, 1L },
                    { 8L, 8L, 1L },
                    { 7L, 7L, 1L },
                    { 6L, 6L, 1L },
                    { 5L, 5L, 1L },
                    { 4L, 4L, 1L },
                    { 3L, 3L, 1L },
                    { 2L, 2L, 1L },
                    { 1L, 1L, 1L },
                    { 10L, 10L, 1L },
                    { 22L, 22L, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GuildId_DisplayName",
                table: "AspNetUsers",
                columns: new[] { "GuildId", "DisplayName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BossHasItems_ChildId",
                table: "BossHasItems",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_BossHasItems_ParentId_ChildId",
                table: "BossHasItems",
                columns: new[] { "ParentId", "ChildId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPriorities_CharacterId",
                table: "CharacterPriorities",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPriorities_ItemPriorityId",
                table: "CharacterPriorities",
                column: "ItemPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildHasCharacters_ChildId",
                table: "GuildHasCharacters",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildHasCharacters_ParentId_ChildId",
                table: "GuildHasCharacters",
                columns: new[] { "ParentId", "ChildId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GuildHasRaidTeams_ChildId",
                table: "GuildHasRaidTeams",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildHasRaidTeams_ParentId_ChildId",
                table: "GuildHasRaidTeams",
                columns: new[] { "ParentId", "ChildId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guilds_Code",
                table: "Guilds",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPriorities_ItemId",
                table: "ItemPriorities",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Loots_CharacterId",
                table: "Loots",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Loots_ItemId",
                table: "Loots",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RaidEventHasLoots_ChildId",
                table: "RaidEventHasLoots",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_RaidEventHasLoots_ParentId_ChildId",
                table: "RaidEventHasLoots",
                columns: new[] { "ParentId", "ChildId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RaidEvents_RaidId",
                table: "RaidEvents",
                column: "RaidId");

            migrationBuilder.CreateIndex(
                name: "IX_RaidEvents_RaidTeamId_RaidId_Date",
                table: "RaidEvents",
                columns: new[] { "RaidTeamId", "RaidId", "Date" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RaidHasBosses_ChildId",
                table: "RaidHasBosses",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_RaidHasBosses_ParentId_ChildId",
                table: "RaidHasBosses",
                columns: new[] { "ParentId", "ChildId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Raids_Name",
                table: "Raids",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Raids_ShortName",
                table: "Raids",
                column: "ShortName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BossHasItems");

            migrationBuilder.DropTable(
                name: "CharacterPriorities");

            migrationBuilder.DropTable(
                name: "GuildHasCharacters");

            migrationBuilder.DropTable(
                name: "GuildHasRaidTeams");

            migrationBuilder.DropTable(
                name: "RaidEventHasLoots");

            migrationBuilder.DropTable(
                name: "RaidHasBosses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ItemPriorities");

            migrationBuilder.DropTable(
                name: "Loots");

            migrationBuilder.DropTable(
                name: "RaidEvents");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Guilds");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Raids");

            migrationBuilder.DropTable(
                name: "RaidTeams");
        }
    }
}
