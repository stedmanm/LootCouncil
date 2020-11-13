using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Models.Validation
{
    public class ValidationResult
    {
        private readonly IList<string> errors = new List<string>();

        public ICollection<string> Errors => errors;

        public bool Succeeded => !errors.Any();

        public void AddError(string error)
        {
            errors.Add(error);
        }
    }
}
