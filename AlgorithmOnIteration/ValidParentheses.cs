using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmOnIteration
{
    class ValidParentheses
    {
        public static bool IsValid(string s = "(]")
        {
            string dup = string.Empty;
            while (s != dup)
            {
                dup = s;
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return s == string.Empty ? true : false;
        }
    }
    
}
