using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly IRepositoryServices repositoryServices;

        protected AppDbContext AppDbContext => repositoryServices.AppDbContext;

        protected Guild Guild => repositoryServices.UserProvider.GetCurrentUser().Guild;

        public RepositoryBase(IRepositoryServices repositoryServices)
        {
            this.repositoryServices = repositoryServices;
        }
    }
}
