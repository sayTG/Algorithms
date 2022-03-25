using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOnIteration
{
    class SmallestString
    {
        public static string GetSmallestString(int n, int k)
        {
            char[] ans = Enumerable.Repeat('a', n).ToArray();
            k = k - n;

            for (int i = n - 1; i >= 0; i--)
            {
                int diff = Math.Min(k, 25);
                ans[i] = (char)('a' + diff);
                k = k - diff;
            }
            return new string(ans);
        }
    }
}
