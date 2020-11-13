using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace LootCouncil.Models.Entities
{
    public static class EntityHelpers
    {
        public static string GetClassColor(this Class playerClass)
        {
            if (playerClass == Class.Warrior)
                return "#C79C6E";
            if (playerClass == Class.Rogue)
                return "#FFF569";
            if (playerClass == Class.Mage)
                return "#40C7EB";
            if (playerClass == Class.Warlock)
                return "#8787ED";
            if (playerClass == Class.Shaman)
                return "#0070DE";
            if (playerClass == Class.Priest)
                return "#FFFFFF";
            if (playerClass == Class.Paladin)
                return "#F58CBA";
            if (playerClass == Class.Hunter)
                return "#A9D271";
            if (playerClass == Class.Druid)
                return "#FF7D0A";

            throw new ArgumentException($"No color was found for class {playerClass}.");
        }

        public static bool BelongsToFaction(this Race race, Faction faction)
        {
            return GetRacesForFaction(faction).Contains(race);
        }

        public static bool BelongsToFaction(this Class playerClass, Faction faction)
        {
            return GetClassesForFaction(faction).Contains(playerClass);
        }

        public static IEnumerable<Race> GetRacesForFaction(Faction faction)
        {
            if (faction == Faction.Alliance)
            {
                yield return Race.Dwarf;
                yield return Race.Gnome;
                yield return Race.Human;
                yield return Race.NightElf;
            }
            else
            {
                yield return Race.Orc;
                yield return Race.Troll;
                yield return Race.Tauren;
                yield return Race.Undead;
            }
        }

        public static IEnumerable<Class> GetClassesForFaction(Faction faction)
        {
            yield return Class.Warrior;
            yield return Class.Rogue;
            yield return Class.Hunter;
            yield return Class.Mage;
            yield return Class.Priest;
            yield return Class.Warlock;
            yield return Class.Druid;

            if (faction == Faction.Alliance)
                yield return Class.Paladin;
            else
                yield return Class.Shaman;
        }

        public static IEnumerable<Class> GetClassesForRace(Race race)
        {
            if (race.In(Race.Troll, Race.Undead, Race.Gnome, Race.Human))
                yield return Class.Mage;
            if (race.In(Race.Orc, Race.Undead, Race.Gnome, Race.Human))
                yield return Class.Warlock;
            if (race.In(Race.Troll, Race.Undead, Race.Dwarf, Race.Human, Race.NightElf))
                yield return Class.Priest;
            if (race.In(Race.Tauren, Race.NightElf))
                yield return Class.Druid;
            if (race.In(Race.Dwarf, Race.Human))
                yield return Class.Paladin;
            if (race.In(Race.Orc, Race.Troll, Race.Tauren))
                yield return Class.Shaman;
            if (race.In(Race.Orc, Race.Troll, Race.Tauren, Race.Dwarf, Race.NightElf))
                yield return Class.Hunter;
            if (race.In(Race.Orc, Race.Troll, Race.Undead, Race.Dwarf, Race.NightElf, Race.Human, Race.Gnome))
                yield return Class.Rogue;

            yield return Class.Warrior;
        }

        public static void UpdateEntityProperties<TEntity>(this TEntity target, TEntity source) where TEntity : Entity
        {
            foreach (PropertyInfo property in typeof(TEntity).GetProperties().Where(p => p.CanWrite))
            {
                if (target is EntityWithDeleteTracking && property.Name == nameof(EntityWithDeleteTracking.IsDeleted))
                    continue;

                if (property.Name == nameof(Entity.Id))
                    continue;

                property.SetValue(target, property.GetValue(source, null), null);
            }
        }

        public static IEnumerable<string> GetPropertyNamesOfEntityTypes(this Type type)
        {
            return type.GetProperties().Where(p => p.PropertyType.InheritsFromType(typeof(Entity))).Select(p => p.Name);
        }

        public static bool IsValidEntityForAddOrUpdate<TEntity>(this TEntity existingEntity, TEntity newOrUpdatedEntity) where TEntity : Entity
        {
            if (existingEntity == null)
                return true;

            if (newOrUpdatedEntity.IsNew)
                return false;

            return existingEntity.Equals(newOrUpdatedEntity);
        }
    }
}
