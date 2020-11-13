using LootCouncil.Models.Database;
using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IRepositoryServices
    {
        public AppDbContext AppDbContext { get; }
        public IUserProvider UserProvider { get; }
    }

    public class RepositoryServices : IRepositoryServices
    {
        public RepositoryServices(AppDbContext appDbContext, IUserProvider userProvider)
        {
            AppDbContext = appDbContext;
            UserProvider = userProvider;
        }

        public AppDbContext AppDbContext { get; }
        public IUserProvider UserProvider { get; }
    }
}
