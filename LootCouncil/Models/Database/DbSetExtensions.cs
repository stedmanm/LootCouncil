using LootCouncil.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database
{
    public static class DbSetExtensions
    {
        private static IQueryable<THasEntity> IncludeChildEntities<THasEntity, TParent, TChild>(this IQueryable<THasEntity> hasEntities) where THasEntity : HasEntity<TParent, TChild>
                                                                                                                                         where TParent : Entity
                                                                                                                                         where TChild : Entity
        {
            IQueryable<THasEntity> query = hasEntities;
            foreach (string propertyName in typeof(TChild).GetPropertyNamesOfEntityTypes())
            {
                query = query.Include("Child." + propertyName);
            }
            return query;
        }

        private static IQueryable<THasEntity> IncludeParentEntities<THasEntity, TParent, TChild>(this IQueryable<THasEntity> hasEntities) where THasEntity : HasEntity<TParent, TChild>
                                                                                                                                          where TParent : Entity
                                                                                                                                          where TChild : Entity
        {
            IQueryable<THasEntity> query = hasEntities;
            foreach (string propertyName in typeof(TParent).GetPropertyNamesOfEntityTypes())
            {
                query = query.Include("Parent." + propertyName);
            }
            return query;
        }

        public static IQueryable<TEntity> IncludeEntities<TEntity>(this IQueryable<TEntity> entities) where TEntity : Entity
        {
            IQueryable<TEntity> query = entities;
            foreach (string propertyName in typeof(TEntity).GetPropertyNamesOfEntityTypes())
            {
                query = query.Include(propertyName);
            }
            return query;
        }

        public static IQueryable<TChild> QueryChildren<THasEntity, TParent, TChild>(this IQueryable<THasEntity> hasEntities, TParent parent, bool includeEntities = true) where THasEntity : HasEntity<TParent, TChild>
                                                                                                                                                                          where TParent : Entity
                                                                                                                                                                          where TChild : Entity

        {
            IQueryable<THasEntity> query = hasEntities;
            if (includeEntities)
                query = query.IncludeChildEntities<THasEntity, TParent, TChild>();

            return query.Where(h => h.Parent == parent).Select(h => h.Child);
        }

        public static IQueryable<TChild> QueryChildren<THasEntity, TParent, TChild>(this IQueryable<THasEntity> hasEntities, IQueryable<TParent> parents, bool includeEntities = true) where THasEntity : HasEntity<TParent, TChild>
                                                                                                                                                                                       where TParent : Entity
                                                                                                                                                                                       where TChild : Entity

        {
            return from he in includeEntities ? hasEntities.IncludeChildEntities<THasEntity, TParent, TChild>() : hasEntities
                   join p in parents on he.Parent equals p
                   select he.Child;
        }

        public static IDictionary<TChild, TParent> GetParentsByChildren<THasEntity, TParent, TChild>(this IQueryable<THasEntity> hasEntities, TChild[] children, bool includeEntities = true) where THasEntity : HasEntity<TParent, TChild>
                                                                                                                                                                                              where TParent : Entity
                                                                                                                                                                                              where TChild : Entity

        {
            IQueryable<THasEntity> query = hasEntities;

            if (includeEntities)
                query = query.IncludeParentEntities<THasEntity, TParent, TChild>();

            return query.Where(h => children.Contains(h.Child))
                        .Select(h => new { h.Parent, h.Child })
                        .ToDictionary(a => a.Child, a => a.Parent);
        }

        public static TParent GetParentByChild<THasEntity, TParent, TChild>(this IQueryable<THasEntity> hasEntities, TChild child, bool includeEntities = true) where THasEntity : HasEntity<TParent, TChild>
                                                                                                                                   where TParent : Entity
                                                                                                                                   where TChild : Entity

        {
            return hasEntities.GetParentsByChildren<THasEntity, TParent, TChild>(new[] { child }, includeEntities).SingleOrDefault().Value;
        }

        public static TEntity UpdateEntity<TEntity>(this DbSet<TEntity> entities, TEntity modified) where TEntity : Entity
        {
            var existing = entities.Find(modified.Id);

            if (existing != null)
            {
                existing.UpdateEntityProperties(modified);
                entities.Update(existing);
            }

            return existing;
        }

        public static TEntity DeleteEntity<TEntity>(this DbSet<TEntity> entities, long id) where TEntity : Entity
        {
            TEntity entity = entities.Find(id);

            if (entity != null)
            {
                if (entity is EntityWithDeleteTracking entityWithDeleteTracking)
                {
                    entityWithDeleteTracking.IsDeleted = true;
                    entities.Update(entity);
                }
                else
                {
                    entities.Remove(entity);
                }
            }

            return entity;
        }

        public static IQueryable<TEntity> QueryNonDeleted<TEntity>(this IQueryable<TEntity> entities) where TEntity : EntityWithDeleteTracking
        {
            return entities.Where(e => !e.IsDeleted);
        }
    }
}
