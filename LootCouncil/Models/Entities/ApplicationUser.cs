using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public Guild Guild { get; set; }
        
        [Required]
        [MaxLength(EntityRestrictions.UserDisplayNameMaxLength)]
        public string DisplayName { get; set; }
        
        public ApplicationUser()
        {

        }

        public ApplicationUser(string email, string displayName, Guild guild)
        {
            Guild = guild;
            UserName = Email = email;
            DisplayName = displayName;
        }
    }
}
