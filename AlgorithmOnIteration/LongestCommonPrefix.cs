using System.Linq;

namespace AlgorithmOnIteration
{
    class LongestCommonPrefix
    {
        public static string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs.Length == 0 || strs == null)
                return "";
            string output1 = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0].ToCharArray().ElementAt(i);
                for (int j = 1; j < strs.Length; j++)
                {
                    if (j == strs[j].Length || strs[j].ToCharArray().ElementAt(i) != c)
                    {
                        return output1 += c;
                    }
                }
            }
            return output1;

            //most correct answer
            string output = "";
            for (int i = 1; i <= strs[0].Length; i++)
            {
                string j = strs[0].Substring(0, i);
                bool result = strs.All(x => x.StartsWith(j));
                if (result)
                    output = j;
                else break;
            }
            return output;
        }
    }
}
