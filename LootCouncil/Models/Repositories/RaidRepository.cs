using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IRaidRepository
    {
        IList<Raid> GetRaids();
        Raid GetRaidById(long id);
        Raid GetRaidByItem(Item item);
    }

    public class RaidRepository : RepositoryBase, IRaidRepository
    {
        private readonly IBossRepository bossRepository;

        public RaidRepository(IRepositoryServices repositoryServices, IBossRepository bossRepository) : base(repositoryServices)
        {
            this.bossRepository = bossRepository;
        }

        public Raid GetRaidById(long id)
        {
            return AppDbContext.Raids.Find(id);
        }

        public IList<Raid> GetRaids()
        {
            return AppDbContext.Raids.ToList();
        }

        public Raid GetRaidByItem(Item item)
        {
            return AppDbContext.RaidHasBosses.GetParentByChild<RaidHasBoss, Raid, Boss>(bossRepository.GetBossByItem(item));
        }
    }
}
