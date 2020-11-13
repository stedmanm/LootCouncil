﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LootCouncil.Models.Entities
{
    public class RaidTeam : Entity
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; } 
    }
}
