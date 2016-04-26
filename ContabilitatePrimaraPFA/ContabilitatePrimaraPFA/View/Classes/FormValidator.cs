using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContabilitatePrimaraPFA.View.Classes
{
   public class FormValidator
    {
        public static bool NamesValidator(string _value, string pattern)
        {
            bool isValid = false;
            Match match = Regex.Match(_value, pattern,RegexOptions.IgnoreCase);
            if (match.Success)
                isValid = true;
            return isValid;
        }

    }
}
