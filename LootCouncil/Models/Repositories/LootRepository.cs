using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface ILootRepository
    {
        AddOrUpdateLootResult AddLoot(RaidEvent raidEvent, Loot loot);
        AddOrUpdateLootResult UpdateLoot(Loot loot);
        IList<Loot> GetLootByRaidEvent(RaidEvent raidEvent);
        bool HasLoot(RaidEvent raidEvent);
        void DeleteLoot(Loot loot);
        Loot GetLootById(long id);
        Loot GetLootByCharacterAndItem(RaidEvent raidEvent, Character character, Item item);
        IList<Loot> GetLootByCharacter(Character character);
    }

    public class LootRepository : RepositoryBase, ILootRepository
    {
        private readonly IEntityAccessor<Character> characterAccessor;
        private readonly IItemPriorityRepository itemPriorityRepository;

        public LootRepository(IRepositoryServices repositoryServices, IEntityAccessor<Character> characterAccessor, IItemPriorityRepository itemPriorityRepository) : base(repositoryServices)
        {
            this.characterAccessor = characterAccessor;
            this.itemPriorityRepository = itemPriorityRepository;
        }

        public AddOrUpdateLootResult AddLoot(RaidEvent raidEvent, Loot loot)
        {
            using (var transaction = AppDbContext.Database.BeginTransaction())
            {
                RaidEventHasLoot raidEventHasLoot = new RaidEventHasLoot
                {
                    Parent = raidEvent,
                    Child = loot
                };

                AppDbContext.RaidEventHasLoots.Add(raidEventHasLoot);
                AddOrUpdateLootResult result = UpdateItemPriority(loot);
                AppDbContext.SaveChanges();
                transaction.Commit();
                return result;
            }
        }

        public AddOrUpdateLootResult UpdateLoot(Loot loot)
        {
            using (var transaction = AppDbContext.Database.BeginTransaction())
            {
                AppDbContext.Loots.Update(loot);
                AddOrUpdateLootResult result = UpdateItemPriority(loot);
                AppDbContext.SaveChanges();
                transaction.Commit();
                return result;
            }
        }

        public Loot GetLootByCharacterAndItem(RaidEvent raidEvent, Character character, Item item)
        {
            return QueryLootByRaidEvent(raidEvent, true).SingleOrDefault(l => l.Character == character && l.Item == item);
        }

        public IList<Loot> GetLootByCharacter(Character character)
        {
            return AppDbContext.Loots.IncludeEntities().Where(l => l.Character == character).ToList();
        }

        public IList<Loot> GetLootByRaidEvent(RaidEvent raidEvent)
        {
            return QueryLootByRaidEvent(raidEvent, true).ToList();
        }

        public bool HasLoot(RaidEvent raidEvent)
        {
           return QueryLootByRaidEvent(raidEvent, false).Any();
        }

        public void DeleteLoot(Loot loot)
        {
            AppDbContext.Loots.DeleteEntity(loot.Id);
            AppDbContext.SaveChanges();
        }

        public Loot GetLootById(long id)
        {
            Loot loot = AppDbContext.Loots.IncludeEntities().SingleOrDefault(l => l.Id == id);

            if (characterAccessor.HasPermission(loot.Character.Id))
                return loot;

            return null;
        }  

        private IQueryable<Loot> QueryLootByRaidEvent(RaidEvent raidEvent, bool includeEntities)
        {
            return AppDbContext.RaidEventHasLoots.QueryChildren<RaidEventHasLoot, RaidEvent, Loot>(raidEvent, includeEntities);
        }

        private AddOrUpdateLootResult UpdateItemPriority(Loot loot)
        {
            long originalCharacterId = 0;
            long originalItemId = 0;

            var result = new AddOrUpdateLootResult();
            
            if (!loot.IsNew)
            {
                PropertyValues originalValues = AppDbContext.Entry(loot).OriginalValues;
                originalCharacterId = (long)originalValues[nameof(Loot.Character) + "Id"];
                originalItemId = (long)originalValues[nameof(Loot.Item) + "Id"];
            }

            if (loot.IsNew || originalCharacterId != loot.Character.Id || originalItemId != loot.Item.Id)
            {
                ItemPriority itemPriority = itemPriorityRepository.GetItemPriorityByCharacterAndItem(loot.Character, loot.Item);
                if (itemPriority != null)
                {
                    CharacterPriority deleted = itemPriority.DeleteCharacterPriority(loot.Character);
                    
                    result.AffectedItemPriority = itemPriority;
                    result.DeletedCharacterPriority = deleted;
                    
                    itemPriorityRepository.UpdateItemPriority(itemPriority);
                }
            }

            return result;
        }
    }

    public class AddOrUpdateLootResult
    {
        public ItemPriority AffectedItemPriority { get; set; }
        public CharacterPriority DeletedCharacterPriority { get; set; }
    }
}
