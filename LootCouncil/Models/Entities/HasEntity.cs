using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public abstract class HasEntity<TParent, TChild> : Entity where TParent : Entity
                                                              where TChild : Entity
    {
        [Required]
        public TParent Parent { get; set; }
        [Required]
        public TChild Child { get; set; }
    }
}
