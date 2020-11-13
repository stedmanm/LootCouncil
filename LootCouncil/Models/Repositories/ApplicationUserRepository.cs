using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using LootCouncil.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IApplicationUserRepository
    {
        Task<IdentityResult> AddUserAsync(ApplicationUser user, string password, ApplicationRole applicationRole);

        ApplicationUser GetUserByDisplayName(Guild guild, string displayName);
    }

    public class ApplicationUserRepository : RepositoryBase, IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager, IRepositoryServices repositoryServices) : base(repositoryServices)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(ApplicationUser user, string password, ApplicationRole applicationRole)
        {
            using (var transaction = AppDbContext.Database.BeginTransaction())
            {
                var result = await userManager.CreateAsync(user, password);
                if (!result.Succeeded)
                    return result;

                result = await userManager.AddToRoleAsync(user, applicationRole.ToString());
                if (!result.Succeeded)
                    return result;

                if (applicationRole == ApplicationRole.GuildMaster)
                    InitializeGuild(user.Guild);

                transaction.Commit();
                return result;
            }
        }

        public ApplicationUser GetUserByDisplayName(Guild guild, string displayName)
        {
            return AppDbContext.Users.SingleOrDefault(u => u.Guild == guild && u.DisplayName == displayName);
        }

        private void InitializeGuild(Guild guild)
        {
            GuildHasRaidTeam guildHasRaid = new GuildHasRaidTeam
            {
                Parent = guild,
                Child = new RaidTeam
                {
                    Name = "Main"
                }
            };

            AppDbContext.GuildHasRaidTeams.Add(guildHasRaid);

            AppDbContext.SaveChanges();
        }
    }
}
