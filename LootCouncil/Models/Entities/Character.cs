using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class Character : EntityWithDeleteTracking
    {
        private string name;

        [MaxLength(12)]
        [RegularExpression(RegexPatterns.Alphabet, ErrorMessage = "Character name " + Strings.CanOnlyContainLetters)]
        [Required]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.CapitalizeFirstLetter();
            }
        }

        [Required]
        public Class Class { get; set; }
        
        [Required]
        public Race Race { get; set; }

        [Required]
        public CharacterType Type { get; set; }

        public override string ToString()
        {
            return Name + " / " + Class.DisplayEnum() + " / " + Type.DisplayEnum();
        }
    }
}
