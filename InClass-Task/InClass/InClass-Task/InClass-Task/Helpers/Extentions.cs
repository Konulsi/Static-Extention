using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InClass_Task.Helpers
{
    public static class Extentions
    {
      public static int GetNum(this int num)
        {
            return num;
        }

        public static bool CheckString(this string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }


    }
}
