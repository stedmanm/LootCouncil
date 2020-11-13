using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface IEntityAccessor<TEntity> where TEntity : Entity
    {
        public IQueryable<TEntity> QueryAccessibleEntities();
        public bool HasPermission(long entityId);
    }

    public abstract class GuildHasEntityAccessor<THasEntity, TChild> : IEntityAccessor<TChild> where THasEntity : HasEntity<Guild, TChild>, new()
                                                                                               where TChild : Entity
    {
        private readonly DbSet<THasEntity> hasEntities;
        private readonly DbSet<TChild> childEntities;
        private readonly IUserProvider userProvider;

        public GuildHasEntityAccessor(AppDbContext appDbContext, IUserProvider userProvider)
        {
            hasEntities = appDbContext.Set<THasEntity>();
            childEntities = appDbContext.Set<TChild>();
            this.userProvider = userProvider;
        }

        public TChild GetEntity(long id)
        {
            return QueryAccessibleEntities().SingleOrDefault(c => c.Id == id);
        }

        public bool HasPermission(long id)
        {
            return GetEntity(id) != null;
        }

        public TChild UpdateEntity(TChild child)
        {
            if (!HasPermission(child.Id))
                return child;

            return childEntities.UpdateEntity(child);
        }

        public TChild DeleteEntity(long id)
        {
            if (!HasPermission(id))
                return null;

            return childEntities.DeleteEntity(id);
        }

        public TChild AddEntity(TChild child)
        {
            THasEntity hasEntity = new THasEntity
            {
                Parent = userProvider.GetCurrentUser().Guild,
                Child = child
            };

            hasEntities.Add(hasEntity);

            return child;
        }

        public IQueryable<TChild> QueryAccessibleEntities()
        {
            return hasEntities.QueryChildren<THasEntity, Guild, TChild>(userProvider.GetCurrentUser().Guild);
        }
    }

    public class CharacterAccessor : GuildHasEntityAccessor<GuildHasCharacter, Character>
    {
        public CharacterAccessor(AppDbContext appDbContext, IUserProvider userProvider) : base(appDbContext, userProvider)
        {
        }
    }

    public class RaidTeamAccessor : GuildHasEntityAccessor<GuildHasRaidTeam, RaidTeam>
    {
        public RaidTeamAccessor(AppDbContext appDbContext, IUserProvider userProvider) : base(appDbContext, userProvider)
        {
        }
    }
}
