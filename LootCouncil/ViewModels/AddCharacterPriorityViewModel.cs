using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class AddCharacterPriorityViewModel
    {
        [Required]
        public string CharacterName { get; set; }
        [Required]
        public long ItemPriorityId { get; set; }
    }
}
