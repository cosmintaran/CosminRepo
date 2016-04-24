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
        public static bool NamesValidator(string _value)
        {
            bool isValid = false;
            string pattern = "[A-Za-z]";
            Match match = Regex.Match(_value, pattern,RegexOptions.IgnoreCase);
            if (match.Success)
                isValid = true;
            return isValid;
        }

    }
}
