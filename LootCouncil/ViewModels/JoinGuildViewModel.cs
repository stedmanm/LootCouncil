using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.ViewModels
{
    public class JoinGuildViewModel : RegistrationViewModel
    {
        [Required]
        [DisplayName("Guild Code")]
        public string GuildCode { get; set; }
    }
}
