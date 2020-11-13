using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IGuildRepository
    {
        Guild GetGuildByCode(string code);
    }

    public class GuildRepository : RepositoryBase, IGuildRepository
    {
        public GuildRepository(IRepositoryServices repositoryServices) : base(repositoryServices)
        {
        }

        public Guild GetGuildByCode(string code)
        {
            return AppDbContext.Guilds.SingleOrDefault(g => g.Code == code);
        }   
    }
}
