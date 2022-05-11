using System.Text.RegularExpressions;

namespace FinancialAssetsWallet.Domain.Model.Extensions
{
    public static class RegexExtensions
    {
        public static string NameValidationRegex = "^.*$";

        public static string EraseNonNumericCharacters(this string @string)
        {
            return Regex.Replace(@string, "[^0-9]", string.Empty);
        }
    }
}