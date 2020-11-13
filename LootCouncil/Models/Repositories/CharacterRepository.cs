using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using LootCouncil.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Repositories
{
    public interface ICharacterRepository
    {
        Character AddCharacter(Character character);
        Character UpdateCharacter(Character character);
        Character GetCharacterByName(string name);
        Character GetCharacterById(long id);
        Character DeleteCharacter(long id);
        IList<Character> GetCharacters();
    }

    public class CharacterRepository : RepositoryBase, ICharacterRepository
    {
        private readonly CharacterAccessor characterAccessor;
        private readonly IItemPriorityRepository itemPriorityRepository;

        public CharacterRepository(IRepositoryServices repositoryServices, IItemPriorityRepository itemPriorityRepository, CharacterAccessor characterAccessor) : base(repositoryServices)
        {
            this.characterAccessor = characterAccessor;
            this.itemPriorityRepository = itemPriorityRepository;
        }

        public Character AddCharacter(Character character)
        {
            var deletedCharacter = GetCharacterByName(character.Name, false);

            if (deletedCharacter != null)
            {
                if (!deletedCharacter.IsDeleted)
                    throw new ArgumentException($"Character with name {character.Name} already exists.");

                deletedCharacter.UpdateEntityProperties(character);
                deletedCharacter.IsDeleted = false;
                AppDbContext.Characters.Update(deletedCharacter);
                AppDbContext.SaveChanges();
                return deletedCharacter;
            }

            characterAccessor.AddEntity(character);
            AppDbContext.SaveChanges();
            return character;
        }

        public Character DeleteCharacter(long id)
        {
            Character character = characterAccessor.GetEntity(id);

            using (var transaction = AppDbContext.Database.BeginTransaction())
            {
                foreach (ItemPriority itemPriority in itemPriorityRepository.GetItemPrioritiesByCharacter(character))
                {
                    itemPriority.DeleteCharacterPriority(character);
                    itemPriorityRepository.UpdateItemPriority(itemPriority);
                }

                characterAccessor.DeleteEntity(id);
                AppDbContext.SaveChanges();
                transaction.Commit();
            }

            return character;
        }

        public Character GetCharacterById(long id)
        {
            return characterAccessor.GetEntity(id);
        }

        public Character GetCharacterByName(string name)
        {
            return GetCharacterByName(name, true);
        }

        public IList<Character> GetCharacters()
        {
            return QueryAccessibleCharacters().ToList();
        }

        public Character UpdateCharacter(Character character)
        {
            characterAccessor.UpdateEntity(character);
            AppDbContext.SaveChanges();
            return character;
        }

        private IQueryable<Character> QueryAccessibleCharacters(bool ignoreDeleted = true)
        {
            IQueryable<Character> characters = characterAccessor.QueryAccessibleEntities();

            if (!ignoreDeleted)
                return characters;

            return characters.QueryNonDeleted();
        }

        private Character GetCharacterByName(string name, bool ignoreDeleted)
        {
            return QueryAccessibleCharacters(ignoreDeleted).SingleOrDefault(c => c.Name == name);
        }
    }
}
