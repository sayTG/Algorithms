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
            var listA = new List<string> { "a", "b", "c" };
            var listB = new List<string> { "b", "c", "a" };

            foreach (var item in listB)
            {
                if (!listA.Contains(item))
                    Console.WriteLine("N0t found!");
                else
                    Console.WriteLine("found!");
            }
            
            var list = new List<int> { 2, 0,5, 3, 0,2 };
            int count = 0;
            List<int> ans = new List<int>();
            foreach (var item in list)
            {
                if (item == 0)
                    count += 1;
                else
                    ans.Add(item);
            }
            for(int i = 0; i < count; i++)
            {
                ans.Add(0);
            }
            Console.WriteLine(String.Join(", ", ans));
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
                var list = new List<int>() { 1, 0, 5, 3, 4 };
                list.Sort();
                Console.WriteLine(String.Join(", ", list));
            }
        }
        private static void TwoSumOptimised()
        {
            int[] ans = ThreeSumIteration.TwoSumIteration.TwoSumOptimized(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 9);
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
