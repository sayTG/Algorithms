using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOnIteration
{
    class HourGlassSum
    {
        public static int HourglassSum(List<List<int>> arr)
        {
            if (arr.Count == 0)
                return 0;
            List<int> sums = new List<int>();
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int stop = 1;
                    for (int k = j; k < arr[i].Count; k++)
                    {
                        if (stop < 4 && i < arr[i].Count - 2)
                        {
                            sum += arr[i][k] + arr[i + 2][k];
                            stop += 1;
                        }
                        else
                            break;
                    }
                    if (i < arr[i].Count - 1)
                    {
                        sums.Add(sum + arr[i + 1][j + 1]);
                        Console.WriteLine(String.Join(",", sums));
                    }
                    sum = 0;
                }
            }
            return sums.Max();
        }
    }
}
