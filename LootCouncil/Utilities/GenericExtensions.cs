using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Utilities
{
    public static class GenericExtensions
    {
        public static bool In<T>(this T searchValue, params T[] valuesToSearch)
        {
            if (valuesToSearch == null)
                return false;

            return valuesToSearch.Any(v => v.Equals(searchValue));
        }

        public static string DisplayEnum<T>(this T enumVal) where T : Enum
        {
            return enumVal.ToString().SplitCamelCase();
        }

        public static string JoinToString<T>(this IEnumerable<T> values, string seperator = ", ")
        {
            return string.Join(seperator, values);
        }
    }
}
