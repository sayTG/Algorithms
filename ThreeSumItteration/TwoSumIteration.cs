using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumIteration
{
    public class TwoSumIteration
    {
        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            //Declarations
            int arrayLength = nums.Length;
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();
            //Validations
            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }
            //Logic
            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] {
                firstNumber,
                secondNumber
            };
                }
                //resultDictionary.Add(firstNumber, i);
                resultDictionary[firstNumber] = i;
            }
            return Array.Empty<int>(); ;
        }
    }
}
