using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOnIteration
{
    public class CamelCase
    {
        public static string CamelCaseStr(string str)
        {
            string[] splitStr = str.Split(' ');
            string output = "";
            for (int i = 0; i < splitStr.Length; i++)
            {
                splitStr[i] = splitStr[i].ToLower();
                bool first = true;
                bool next = false;
                foreach (char c in splitStr[i])
                {
                    if (first && char.IsLetter(c) || next)
                    {
                        char d = char.ToUpper(c);
                        output += d;
                        first = false;
                        next = false;
                    }
                    else if(!first && char.IsLetter(c))
                    {
                        output += c;
                    }
                    else if (char.IsPunctuation(c))
                    {
                        next = true;
                    }
                }
            }
            return output.Substring(0, 1).ToLower() + output.Substring(1);
        }
    }
}
