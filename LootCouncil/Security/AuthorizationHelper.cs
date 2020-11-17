using LootCouncil.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Security
{
    public static class AuthorizationHelper
    {
        public const string AdminRoles = GuildMasterRole + "," + nameof(ApplicationRole.Admin);
        public const string GuildMasterRole = nameof(ApplicationRole.GuildMaster);
    }
}
