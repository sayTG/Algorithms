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
        public static string StringManipulationMethod3(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
        public static int makeAnagram(string a, string b)
        {
            int count = 0;
            foreach (char c in b)
            {
                Console.WriteLine("character is: " + c);
                if (a.Any(x => x == c))
                {
                    count += 2;
                    int charCountA = a.Where(x => x == c).Count();
                    Console.WriteLine("charCountA: " + charCountA);
                    if (charCountA > 1)
                    {
                        int charCountB = b.Where(x => x == c).Count();
                        Console.WriteLine("charCountB: " + charCountB);
                        if (charCountA <= charCountB)
                        {
                            count -= 2;
                            count += charCountA * 2;
                            Console.WriteLine("count in charA: " + count);
                        }
                        else if (charCountB <= charCountA)
                        {
                            count -= 2;
                            count += charCountB * 2;
                            Console.WriteLine("count in charB: " + count);
                        }
                    }
                    a = a.Replace(c, char.MaxValue);
                    Console.WriteLine("Replace: " + a);
                    Console.WriteLine("Count" + count);
                }
            }
            Console.WriteLine("kkjhgfgh");
            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);
            Console.WriteLine(count);
            Console.WriteLine(char.MinValue);
            return a.Length + b.Length - count;
        }
    }
}
