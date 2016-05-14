
namespace ContabilitatePrimaraPFA.View.Classes
{
    using System.Text.RegularExpressions;

    public class FormValidator
    {
        public static bool NamesValidator(string value, string pattern)
        {
            var isValid = false;
            var match = Regex.Match(value, pattern,RegexOptions.IgnoreCase);
            if (match.Success)
                isValid = true;
            return isValid;
        }

    }
}
