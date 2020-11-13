using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IRaidTeamRepository
    {
        IList<RaidTeam> GetRaidTeams();
        RaidTeam AddRaidTeam(RaidTeam raidTeam);
        RaidTeam GetRaidTeamById(long id);
        RaidTeam DeleteRaidTeam(long id);
        RaidTeam GetRaidTeamByName(string name);
        RaidTeam UpdateRaidTeam(RaidTeam raidTeam);
    }

    public class RaidTeamRepository : RepositoryBase, IRaidTeamRepository
    {
        private readonly RaidTeamAccessor raidTeamAccessor;

        public RaidTeamRepository(IRepositoryServices repositoryServices, RaidTeamAccessor raidTeamAccessor) : base(repositoryServices)
        {
            this.raidTeamAccessor = raidTeamAccessor;
        }
        public IList<RaidTeam> GetRaidTeams()
        {
            return QueryAccessibleRaidTeams().ToList();
        }

        public RaidTeam GetRaidTeamById(long id)
        {
            return raidTeamAccessor.GetEntity(id);
        }

        public RaidTeam GetRaidTeamByName(string name)
        {
            return QueryAccessibleRaidTeams().SingleOrDefault(r => r.Name == name);
        }

        public RaidTeam UpdateRaidTeam(RaidTeam raidTeam)
        {
            raidTeamAccessor.UpdateEntity(raidTeam);
            AppDbContext.SaveChanges();
            return raidTeam;
        }

        public RaidTeam AddRaidTeam(RaidTeam raidTeam)
        {
            raidTeamAccessor.AddEntity(raidTeam);
            AppDbContext.SaveChanges();
            return raidTeam;
        }

        public RaidTeam DeleteRaidTeam(long id)
        {
            RaidTeam raidTeam = raidTeamAccessor.DeleteEntity(id);
            AppDbContext.SaveChanges();
            return raidTeam;
        }
        
        private IQueryable<RaidTeam> QueryAccessibleRaidTeams()
        {
            return raidTeamAccessor.QueryAccessibleEntities();
        }
    }
}
