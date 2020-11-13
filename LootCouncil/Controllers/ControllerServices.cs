using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Utilities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Controllers
{
    public interface IControllerServices
    {
        IUserProvider UserProvider { get; }
    }

    public class ControllerServices : IControllerServices
    {
        public ControllerServices(IUserProvider userProvider)
        {
            UserProvider = userProvider;
        }

        public IUserProvider UserProvider { get; }
    }
}
