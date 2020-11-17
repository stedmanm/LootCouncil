using LootCouncil.Models.Database.Raids;
using LootCouncil.Models.Entities;
using LootCouncil.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Guild>()
                        .HasIndex(b => b.Code)
                        .IsUnique();

            modelBuilder.Entity<ApplicationUser>()
                        .HasIndex(nameof(ApplicationUser.Guild) + "Id", nameof(ApplicationUser.DisplayName))
                        .IsUnique();

            modelBuilder.Entity<Raid>()
                        .HasIndex(r => r.Name)
                        .IsUnique();

            modelBuilder.Entity<Raid>()
                        .HasIndex(r => r.ShortName)
                        .IsUnique();


            modelBuilder.Entity<RaidEvent>()
                        .HasIndex(nameof(RaidEvent.RaidTeam) + "Id", nameof(RaidEvent.Raid) + "Id", nameof(RaidEvent.Date))
                        .IsUnique();

            modelBuilder.BuildUniqueConstraintForHasEntities();
            modelBuilder.PopulateIdentityRoles();
            RaidPopulator.PopulateRaids(modelBuilder);
        }

        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<GuildHasCharacter> GuildHasCharacters { get; set; }
        public DbSet<RaidTeam> RaidTeams { get; set; }
        public DbSet<GuildHasRaidTeam> GuildHasRaidTeams { get; set; }
        public DbSet<Raid> Raids { get; set; }
        public DbSet<RaidEvent> RaidEvents { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<RaidHasBoss> RaidHasBosses { get; set; }
        public DbSet<BossHasItem> BossHasItems { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<RaidEventHasLoot> RaidEventHasLoots { get; set; }
        public DbSet<Loot> Loots { get; set; }
        public DbSet<ItemPriority> ItemPriorities { get; set; }
        public DbSet<CharacterPriority> CharacterPriorities { get; set; }
    }
}
