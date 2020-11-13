using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LootCouncil.Razor
{
    public static class RazorPageHelper
    {
        public const string PageTitleKey = "PageTitle";
        public const string SuccessMessageKey = "SuccessMessage";
        public const string ErrorMessageKey = "ErrorMessage";
        public const string ViewNameKey = "HtmlFileName";

        public const string ItemDropDownId = "itemNames";
        public const string ItemDropDownView = @"..\Shared\_ItemDropDown";

        public const string CharacterDropDownId = "characterNames";
        public const string CharacterDropDownView = @"..\Shared\_CharacterDropDown";
    }
}
