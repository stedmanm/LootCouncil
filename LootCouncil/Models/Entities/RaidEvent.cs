using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class RaidEvent : Entity
    {
        [Required]
        public RaidTeam RaidTeam { get; set; }
        
        [Required]
        public Raid Raid { get; set; }
        
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Raid.ShortName + " / " + Date.ToShortDateString() + " / " + RaidTeam.Name;
        }
    }
}
