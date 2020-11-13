using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class EntityWithDeleteTracking : Entity
    {
        [Required]
        public bool IsDeleted { get; set; }
    }
}
