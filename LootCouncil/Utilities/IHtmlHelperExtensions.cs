using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Utilities
{
    public static class IHtmlHelperExtensions
    {
        public static IEnumerable<SelectListItem> GetEnumSelectList<TEnum>(this IHtmlHelper htmlHelper, bool splitCamelCase, Func<TEnum, bool> filter = null) where TEnum : struct
        {
            if (filter == null)
                filter = i => true;

            IEnumerable<SelectListItem> items = htmlHelper.GetEnumSelectList<TEnum>().Where(s => filter((TEnum)(object)int.Parse(s.Value)));

            if (!splitCamelCase)
                return items;

            return items.Select(i =>
            {
                i.Text = i.Text.SplitCamelCase();
                return i;
            });
        }
    }
}
