using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IItemPriorityRepository
    {
        ItemPriority AddItemPriority(ItemPriority itemPriority);
        ItemPriority GetItemPriorityByName(string name);
        ItemPriority GetItemPriorityByCharacterAndItem(Character character, Item item);
        IList<ItemPriority> GetItemPrioritiesByCharacter(Character character);
        ItemPriority UpdateItemPriority(ItemPriority itemPriority);
        ItemPriority DeleteItemPriority(ItemPriority itemPriority);
        IList<ItemPriority> GetItemPrioritiesByRaid(Raid raid);
        ItemPriority GetItemPriorityById(long id);
        ItemPriority GetItemPriorityByCharacterPriorityId(long characterPriorityId);
    }

    public class ItemPriorityRepository : RepositoryBase, IItemPriorityRepository
    {
        private readonly IEntityAccessor<Character> characterAccessor;
        private readonly IItemRepository itemRepository;

        public ItemPriorityRepository(IRepositoryServices repositoryServices, IEntityAccessor<Character> characterAccessor, IItemRepository itemRepository) : base(repositoryServices)
        {
            this.characterAccessor = characterAccessor;
            this.itemRepository = itemRepository;
        }

        public ItemPriority AddItemPriority(ItemPriority itemPriority)
        {
            AppDbContext.ItemPriorities.Add(itemPriority);
            AppDbContext.SaveChanges();
            return itemPriority;
        }

        public ItemPriority GetItemPriorityByName(string name)
        {
            return QueryAccessibleItemPriorities().SingleOrDefault(ip => ip.Name == name);
        }

        public ItemPriority GetItemPriorityByCharacterAndItem(Character character, Item item)
        {
            return QueryItemPrioritiesByCharacter(character).SingleOrDefault(ip => ip.Item == item);
        }

        public IList<ItemPriority> GetItemPrioritiesByCharacter(Character character)
        {
            return QueryItemPrioritiesByCharacter(character).ToList();
        }

        public IList<ItemPriority> GetItemPrioritiesByRaid(Raid raid)
        {
            return (from ip in QueryAccessibleItemPriorities()
                    join i in itemRepository.QueryItemsByRaid(raid) on ip.Item equals i
                    select ip).ToList();
        }

        public ItemPriority GetItemPriorityByCharacterPriorityId(long characterPriorityId)
        {
            return (from ip in QueryAccessibleItemPriorities()
                    join cp in AppDbContext.CharacterPriorities on ip.Id equals cp.ItemPriorityId
                    where cp.Id == characterPriorityId
                    select ip).SingleOrDefault();
        }

        private IQueryable<ItemPriority> QueryItemPrioritiesByCharacter(Character character)
        {
            return (from ip in AppDbContext.ItemPriorities.IncludeEntities()
                    join cp in AppDbContext.CharacterPriorities on ip.Id equals cp.ItemPriorityId
                    where cp.Character == character
                    select ip);
        }

        private IQueryable<ItemPriority> QueryAccessibleItemPriorities()
        {
            return (from ip in AppDbContext.ItemPriorities.IncludeEntities()
                    join cp in AppDbContext.CharacterPriorities on ip.Id equals cp.ItemPriorityId
                    join c in characterAccessor.QueryAccessibleEntities() on cp.Character equals c
                    select ip).Distinct();
        }

        public ItemPriority UpdateItemPriority(ItemPriority itemPriority)
        {
            if (itemPriority.Priorities.Count == 0)
                return DeleteItemPriority(itemPriority);

            AppDbContext.ItemPriorities.Update(itemPriority);
            AppDbContext.SaveChanges();
            return itemPriority;
        }

        public ItemPriority DeleteItemPriority(ItemPriority itemPriority)
        {
            AppDbContext.ItemPriorities.DeleteEntity(itemPriority.Id);
            AppDbContext.SaveChanges();
            return itemPriority;
        }

        public ItemPriority GetItemPriorityById(long id)
        {
            return QueryAccessibleItemPriorities().SingleOrDefault(i => i.Id == id);
        }
    }

    public static class ItemPriorityExtensions
    {
        public static IQueryable<ItemPriority> IncludeEntities(this IQueryable<ItemPriority> itemPriorities)
        {
            return itemPriorities.Include(i => i.Priorities).ThenInclude(p => p.Character).Include(i => i.Item);
        }
    }
}
