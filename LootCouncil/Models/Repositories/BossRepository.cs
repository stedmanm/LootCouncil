using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IBossRepository
    {
        IQueryable<Boss> QueryBossesByRaid(Raid raid);
        IDictionary<Item, Boss> GetBossesByItems(Item[] items);
        Boss GetBossByItem(Item item);
    }

    public class BossRepository : RepositoryBase, IBossRepository
    {
        public BossRepository(IRepositoryServices repositoryServices) : base(repositoryServices)
        {
        }

        public IQueryable<Boss> QueryBossesByRaid(Raid raid)
        {
            return AppDbContext.RaidHasBosses.QueryChildren<RaidHasBoss, Raid, Boss>(raid);
        }

        public IDictionary<Item, Boss> GetBossesByItems(Item[] items)
        {
            return AppDbContext.BossHasItems.GetParentsByChildren<BossHasItem, Boss, Item>(items);
        }

        public Boss GetBossByItem(Item item)
        {
            return AppDbContext.BossHasItems.GetParentByChild<BossHasItem, Boss, Item>(item);
        }
    }
}
