using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public bool IsNew => Id == 0;

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() == GetType() && ((Entity)obj).Id == Id)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
