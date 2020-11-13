using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class Guild : Entity
    {
        [Required]
        [Display(Name = "Guild Name")]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Guild Code")]
        [MaxLength(10)]
        [RegularExpression(RegexPatterns.AlphaNumeric, ErrorMessage = "Guild code can only contain letters and numbers.")]
        public string Code { get; set; }

        [Required]
        public Faction Faction { get; set; }
    }
}
