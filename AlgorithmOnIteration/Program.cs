using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeSumIteration;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreeSumToZeroIteration();
            Console.Read();
        }

        private static void ThreeSumToZeroIteration()
        {
            int[] a = new int[10] { 2, -4, 5, 6, 8, 9, 10, -3, -4, 6 };
            int[,] b = new int[2, 3] { { 2, 3, 4}, { 4, 5, 6 } }; //multi dimensional array
            int[][] jaggedArray = new int[3][]; //jagged array has fixed rows and varying columns. You have to intialize the rows of a jagged array with its size.


            var answer = ThreeSumIteration.ThreeSumIteration.Count(a);
            if (answer != null)
            {
                Console.WriteLine(String.Join(", ", answer));
            }
        }
        private static void TwoSumOptimised()
        {
            int[] ans = ThreeSumIteration.TwoSumIteration.TwoSumOptimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 9);
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
