using System.Collections.Generic;
using System.Linq;

namespace AlgorithmOnIteration
{
    class RomanToInt
    {
        public int RomanToIntMethod(string s)
        {
            List<int> result = new List<int>();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            keyValuePairs.Add('I', 1);
            keyValuePairs.Add('V', 5);
            keyValuePairs.Add('X', 10);
            keyValuePairs.Add('L', 50);
            keyValuePairs.Add('C', 100);
            keyValuePairs.Add('D', 500);
            keyValuePairs.Add('M', 1000);

            foreach (char c in s)
            {

                if (result.Count() != 0)
                {
                    if (result.Last() >= keyValuePairs.Where(x => x.Key == c).Select(x => x.Value).FirstOrDefault())
                        result.Add(keyValuePairs.Where(x => x.Key == c).Select(x => x.Value).FirstOrDefault());
                    else
                    {
                        int diff = keyValuePairs.Where(x => x.Key == c).Select(x => x.Value).FirstOrDefault() - result.Last();
                        result.RemoveAt(result.Count() - 1);
                        result.Add(diff);
                    }
                }
                else
                    result.Add(keyValuePairs.Where(x => x.Key == c).Select(x => x.Value).FirstOrDefault());
            }
            return result.Sum();
        }
    }
}
