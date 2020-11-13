using System;

namespace LootCouncil.Utilities
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            if (value == null || value.Length == 0)
                return true;

            return false;
        }

        public static bool IsNullOrSpaces(this string value)
        {
            if (value.IsNullOrEmpty())
                return true;

            return value.Trim().Length == 0;
        }

        /// <summary>
        /// Places a space before upper case letters.
        /// "HelloBob" would return "Hello Bob".
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SplitCamelCase(this string value)
        {
            if (value.IsNullOrEmpty() || value.Length == 1 || value.ToUpper() == value)
                return value;

            string output = "";
            char previous = value[0];
            output += previous;
            char current;

            for (int i = 1; i < value.Length; i++)
            {
                current = value[i];
                if (Char.IsUpper(current))
                    output += " " + current;
                else
                    output += current;
            }

            return output;
        }

        public static string CapitalizeFirstLetter(this string value)
        {
            string output = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (i == 0)
                    output += Char.ToUpper(value[i]);
                else
                    output += Char.ToLower(value[i]);
            }

            return output;
        }
    }
}
