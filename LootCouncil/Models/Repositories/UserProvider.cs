using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using LootCouncil.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IUserProvider
    {
        public ApplicationUser GetCurrentUser();
    }

    public class UserProvider : IUserProvider
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly AppDbContext appDbContext;
        private readonly Lazy<ApplicationUser> currentUser;

        public UserProvider(IHttpContextAccessor httpContextAccessor, AppDbContext appDbContext)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.appDbContext = appDbContext;

            currentUser = new Lazy<ApplicationUser>(() =>
            {
                string currentUserId = httpContextAccessor.HttpContext?.User.GetId();
                if (currentUserId == null)
                    return null;

                return GetUserById(currentUserId);
            });
        }

        public ApplicationUser GetCurrentUser()
        {
            return currentUser.Value;
        }

        private ApplicationUser GetUserById(string id)
        {
            return appDbContext.Users.Include(u => u.Guild).SingleOrDefault(u => u.Id == id);
        }
    }
}
