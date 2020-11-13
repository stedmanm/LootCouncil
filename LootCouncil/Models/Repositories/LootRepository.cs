using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface ILootRepository
    {
        Loot AddLoot(RaidEvent raidEvent, Loot loot);
        Loot UpdateLoot(Loot loot);
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

        public LootRepository(IRepositoryServices repositoryServices, IEntityAccessor<Character> characterAccessor) : base(repositoryServices)
        {
            this.characterAccessor = characterAccessor;
        }

        public Loot AddLoot(RaidEvent raidEvent, Loot loot)
        {
            RaidEventHasLoot raidEventHasLoot = new RaidEventHasLoot
            {
                Parent = raidEvent,
                Child = loot
            };

            AppDbContext.RaidEventHasLoots.Add(raidEventHasLoot);
            AppDbContext.SaveChanges();
            return loot;
        }

        public Loot UpdateLoot(Loot loot)
        {
            AppDbContext.Loots.Update(loot);
            AppDbContext.SaveChanges();
            return loot;
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
    }
}
