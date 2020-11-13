using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class Loot : Entity
    {
        [Required]
        public Character Character { get; set; }

        [Required]
        public Item Item { get; set; }

        [Required]
        public ItemNeedReason ItemNeedReason { get; set; }
    }
}
