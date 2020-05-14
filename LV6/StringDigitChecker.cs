using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV6
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Any(char.IsDigit)) { return true; }
            else { return false; }
        }
    }
}
