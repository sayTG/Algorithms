using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmOnIteration
{
    class RemoveDuplicates
    {
        public static int RemoveDuplicatesMethod(int[] nums)
        {
            if (nums.Length == 0) return 0;
            var c = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                    nums[c++] = nums[i - 1];
            }

            nums[c] = nums[nums.Length - 1];

            return c + 1;
        }
        public static void FindRoots(double a = 1, double b = 5, double c = 4)
        {
            double y = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / 2 * a;
            double z = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / 2 * a;
        }
    }
}