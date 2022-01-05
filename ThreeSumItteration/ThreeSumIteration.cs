using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumIteration
{
    public class ThreeSumIteration
    {
        public static List<int> Count(int[] input)
        {
            for (int i = 0; i < input.Length; i++ )
            {
                for(int j = i + 1; j < input.Length; j++)
                {
                    for(int k = j + 1; k < input.Length; k++)
                    {
                        if (input[i] + input[j] + input[k] == 0)
                        {
                            List<int> triplet = new List<int>()
                            {
                                input[i],
                                input[j],
                                input[k]

                            };
                            return triplet;
                        }
                    }
                }

            }
            return null;
        }
    }
}
