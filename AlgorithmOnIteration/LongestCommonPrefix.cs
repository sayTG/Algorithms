using System.Linq;

namespace AlgorithmOnIteration
{
    class LongestCommonPrefix
    {
        public static string LongestCommonPrefixMethod(string[] strs)
        {
            string output = "";
            output += strs[0].FirstOrDefault();
            char next = 'a';
            if (strs.Length == 1)
                return strs[0];
            else if (strs.Length > 1 && strs[0].ElementAt(0) != strs[1].ElementAt(0))
                return "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    var charA = strs[j].ToCharArray();
                    if (charA[i] != output.Last())
                    {
                        output = output.Remove(output.Length -1);
                        return output;
                    }
                    if (i < strs[0].Length - 1)
                        next = charA[i + 1];
                }
                output += next;
            }
            return output;
        }
    }
}
