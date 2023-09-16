using System.Text.RegularExpressions;

namespace ObraSocial.Domain.Helpers
{
    public static class StringHelper
    {
        public static string RemoveSpecialCharacters(string input)
        {
            string cleaned = Regex.Replace(input, @"[^\w\s]", "");
            cleaned = Regex.Replace(cleaned, @"\s+", " ").Trim();
            return cleaned;
        }

        public static string OnlyNumber(string input)
        {
            string numberOnly = Regex.Replace(input, @"[^\d]", "");
            return numberOnly;
        }
    }
}
