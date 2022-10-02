using System.Collections.Generic;
using System.Linq;

namespace AlgorithmOnIteration
{
    public class LongestPalindrome
    {
        public static string PalindromicSubstring(string str)
        {
            Dictionary<string, int> pal = new Dictionary<string, int>();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 3; j < str.Length; j++)
                {
                    if (i + j <= str.Length)
                    {
                        string sub = str.Substring(i, j);
                        if (isPalidrome(sub))
                            pal.Add(sub, sub.Length);
                    }

                }
            }
            if (pal.Count() == 0)
            {
                str = "none";
            }
            else
                str = pal.OrderByDescending(x => x.Value).Select(x => x.Key).FirstOrDefault().ToString();
            // code goes here  
            return str;

        }
        public static bool isPalidrome(string s)
        {
            string output = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                output += s[i];
            }
            return s == output ? true : false;
        }
    }
}
