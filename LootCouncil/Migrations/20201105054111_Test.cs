using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LootCouncil.Migrations
{
    public partial class Test : Migration
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
                    { "c6965c4a-787c-4cfc-a27e-874ac926e3dc", "909231bd-a7ba-4b0e-9762-dae4dbd94822", "Member", "MEMBER" },
                    { "8cb63961-5d08-498d-9c67-ea4f9ff36ea6", "9cdae67b-ac2d-4a25-a5f8-0dcca7c9de6f", "GuildMaster", "GUILDMASTER" }
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1L, "Lucifron" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1L, "T1 Gloves" });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1L, "Molten Core", "MC" },
                    { 2L, "Blackwing Lair", "BWL" },
                    { 3L, "Temple of Ahn'Qiraj", "AQ40" },
                    { 4L, "Naxxramas", "Naxx" }
                });

            migrationBuilder.InsertData(
                table: "BossHasItems",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[] { 1L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "RaidHasBosses",
                columns: new[] { "Id", "ChildId", "ParentId" },
                values: new object[] { 1L, 1L, 1L });

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
