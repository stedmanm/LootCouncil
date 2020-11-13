using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IItemRepository
    {
        IList<Item> GetItemsByRaid(Raid raid);
        Item GetItemByName(Raid raid, string itemName);
        IQueryable<Item> QueryItemsByRaid(Raid raid);
    }

    public class ItemRepository : RepositoryBase, IItemRepository
    {
        private readonly IBossRepository bossRepository;

        public ItemRepository(IRepositoryServices repositoryServices, IBossRepository bossRepository) : base(repositoryServices)
        {
            this.bossRepository = bossRepository;
        }

        public IList<Item> GetItemsByRaid(Raid raid)
        {
            return QueryItemsByRaid(raid).ToList();
        }

        public Item GetItemByName(Raid raid, string name)
        {
            return QueryItemsByRaid(raid).SingleOrDefault(i => i.Name == name);
        }

        public IQueryable<Item> QueryItemsByRaid(Raid raid)
        {
            return AppDbContext.BossHasItems.QueryChildren<BossHasItem, Boss, Item>(bossRepository.QueryBossesByRaid(raid));
        }
    }
}
