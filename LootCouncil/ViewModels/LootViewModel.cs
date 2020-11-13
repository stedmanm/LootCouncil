using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class LootViewModel : Entity
    {
        [Required]
        public long RaidEventId { get; set; }

        [Required]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DisplayName("Character Name")]
        public string CharacterName { get; set; }

        [Required]
        [DisplayName("Need Reason")]
        public ItemNeedReason ItemNeedReason { get; set; }
    }
}
