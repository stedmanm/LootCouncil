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
        Task<IList<UserAndRole>> GetUserAndRolesAsync();
        ApplicationUser GetUserById(string id);
        Task ChangeUserRoleAsync(ApplicationUser user, ApplicationRole newRole);
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

                result = await AddRoleToUserAsync(user, applicationRole);
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

        public async Task<IList<UserAndRole>> GetUserAndRolesAsync()
        {
            IList<UserAndRole> users = new List<UserAndRole>();

            foreach (ApplicationUser user in QueryAccessibleUsers().ToList())
            {
                ApplicationRole role = await GetUserRoleAsync(user);
                if (role != ApplicationRole.GuildMaster)
                    users.Add(new UserAndRole { User = user, Role = role });
            }

            return users;
        }

        public async Task ChangeUserRoleAsync(ApplicationUser user, ApplicationRole newRole)
        {
            using (var transaction = AppDbContext.Database.BeginTransaction())
            {
                await userManager.RemoveFromRoleAsync(user, (await GetUserRoleAsync(user)).ToString());
                await AddRoleToUserAsync(user, newRole);
                transaction.Commit();
            }
        }

        public ApplicationUser GetUserById(string id)
        {
            return QueryAccessibleUsers().SingleOrDefault(u => u.Id == id);
        }

        private IQueryable<ApplicationUser> QueryAccessibleUsers()
        {
            return AppDbContext.Users.Where(u => u.Guild == Guild);
        }

        private async Task<ApplicationRole> GetUserRoleAsync(ApplicationUser user)
        {
            return (ApplicationRole)Enum.Parse(typeof(ApplicationRole), (await userManager.GetRolesAsync(user)).Single());
        }

        private async Task<IdentityResult> AddRoleToUserAsync(ApplicationUser user, ApplicationRole role)
        {
            return await userManager.AddToRoleAsync(user, role.ToString());
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

    public class UserAndRole
    {
        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
    }
}
