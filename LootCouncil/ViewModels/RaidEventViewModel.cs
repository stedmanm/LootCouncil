using LootCouncil.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class RaidEventViewModel : Entity
    {
        [Required]
        [DisplayName("Raid Team")]
        public long RaidTeamId { get; set; }
        
        [Required]
        [DisplayName("Raid")]
        public long RaidId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
    }
}
