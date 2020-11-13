using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class ItemPriorityNameViewModel : Entity
    {
        [Required]
        [DisplayName("Display Name")]
        [MaxLength(EntityRestrictions.ItemPriorityNameMaxLength)]
        public string ItemPriorityName { get; set; }
    }

    public class ItemPriorityViewModel : ItemPriorityNameViewModel
    {
        public const int CharacterLimit = 10;

        [Required]
        public long RaidId { get; set; }
        
        [Required]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        
        [Required]
        public IList<string> CharacterNames { get; set; }
    }
}
