using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOnIteration
{
    public class StringManipulation
    {
        //string myList = "aaaaabbccbbbddddee";
        public static string StringManipulationMethod(string s)
        {
            int count = 1;
            string temp = s[0].ToString();
            string result = "";
            for(int i = 1; i < s.Length; i++)
            {
                if (s[i] == temp[i - 1])
                {
                    count++;
                }
                else
                {
                    result += s[i - 1];
                    result += count;
                    count = 1;
                }
                temp += s[i];
            }
            result += s[s.Length - 1];
            result += count;

            return result;
        }
        //string myList = "aaaabbccdde";
        public static char StringManipulationMethod2(string s)
        {
            string temp = s[0].ToString();
            for(int i = 1; i < s.Length; i++)
            {
                if(i < s.Length - 1 && s[i] != temp[i-1] && s[i] != s[i + 1])
                {
                    return s[i];
                }
                temp += s[i];
            }
            return s[s.Length - 1];
        }
    }
}
