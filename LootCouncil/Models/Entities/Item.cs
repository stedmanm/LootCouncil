using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class Item : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
