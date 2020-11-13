using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IRaidEventRepository
    {
        RaidEvent AddRaidEvent(RaidEvent raidEvent);
        RaidEvent UpdateRaidEvent(RaidEvent raidEvent);
        RaidEvent GetRaidEventById(long id);
        RaidEvent DeleteRaidEvent(RaidEvent raidEvent);
        bool DoesRaidEventExist(RaidEvent raidEvent);
        bool IsAssociatedWithRaidEvents(RaidTeam raidTeam);
        IList<RaidEvent> GetLatestRaidEvents(int count);
        RaidEvent GetRaidEventByLoot(Loot loot);
        IDictionary<Loot, RaidEvent> GetRaidEventsByLoot(ICollection<Loot> loot);
    }

    public class RaidEventRepository : RepositoryBase, IRaidEventRepository
    {
        private readonly IEntityAccessor<RaidTeam> raidTeamAccessor;

        public RaidEventRepository(IRepositoryServices repositoryServices, IEntityAccessor<RaidTeam> raidTeamAccessor) : base(repositoryServices)
        {
            this.raidTeamAccessor = raidTeamAccessor;
        }

        public RaidEvent AddRaidEvent(RaidEvent raidEvent)
        {
            AppDbContext.RaidEvents.Add(raidEvent);
            AppDbContext.SaveChanges();
            return raidEvent;
        }

        public RaidEvent UpdateRaidEvent(RaidEvent raidEvent)
        {
            AppDbContext.RaidEvents.Update(raidEvent);
            AppDbContext.SaveChanges();
            return raidEvent;
        }

        public bool DoesRaidEventExist(RaidEvent raidEvent)
        {
            return AppDbContext.RaidEvents.Any(r => r.Raid == raidEvent.Raid && r.RaidTeam == raidEvent.RaidTeam && r.Date == raidEvent.Date);
        }

        public bool IsAssociatedWithRaidEvents(RaidTeam raidTeam)
        {
           return AppDbContext.RaidEvents.Any(r => r.RaidTeam == raidTeam);
        }

        public IList<RaidEvent> GetLatestRaidEvents(int count)
        {
            return QueryAccessibleRaidEvents(true).OrderByDescending(r => r.Id)
                                                  .Take(count)
                                                  .ToList();
        }

        public RaidEvent DeleteRaidEvent(RaidEvent raidEvent)
        {
            AppDbContext.RaidEvents.DeleteEntity(raidEvent.Id);
            AppDbContext.SaveChanges();
            return raidEvent;
        }

        private IQueryable<RaidEvent> QueryAccessibleRaidEvents(bool includeEntities)
        {
            IQueryable<RaidEvent> raidEvents = from re in AppDbContext.RaidEvents
                                               join rt in raidTeamAccessor.QueryAccessibleEntities() on re.RaidTeam equals rt
                                               select re;
            if (!includeEntities)
                return raidEvents;

            return raidEvents.IncludeEntities();
        }

        public RaidEvent GetRaidEventById(long id)
        {
            return QueryAccessibleRaidEvents(true).SingleOrDefault(r => r.Id == id);
        }

        public RaidEvent GetRaidEventByLoot(Loot loot)
        {
            return AppDbContext.RaidEventHasLoots.GetParentByChild<RaidEventHasLoot, RaidEvent, Loot>(loot);
        }

        public IDictionary<Loot, RaidEvent> GetRaidEventsByLoot(ICollection<Loot> loot)
        {
            return AppDbContext.RaidEventHasLoots.GetParentsByChildren<RaidEventHasLoot, RaidEvent, Loot>(loot.ToArray());
        }
    }
}
