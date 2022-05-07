using System.Text.RegularExpressions;

namespace FinnacialAssetsWallet.Domain.Model.Extensions
{
    public static class RegexExtensions
    {
        public static string NameValidationRegex = "^.*$";

        //todo"ver dps: Para remover os - do documento
        public static string EraseNonNumericCharacters(this string @string)
        {
            return Regex.Replace(@string, "[^0-9]", string.Empty);
        }
    }
}