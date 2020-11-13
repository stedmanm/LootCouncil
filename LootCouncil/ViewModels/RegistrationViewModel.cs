using LootCouncil.Models.Entities;
using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public abstract class RegistrationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(RegexPatterns.Alphabet, ErrorMessage = "Display name " + Strings.CanOnlyContainLetters)]
        [Display(Name = "Display Name")]
        [MaxLength(EntityRestrictions.UserDisplayNameMaxLength)]
        public string DisplayName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
