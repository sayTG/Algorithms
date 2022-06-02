using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortType
{
    public class BubbleSort
    {
        public static void BubbleSortMethod(int[] array)
        {
            for (int e = array.Length - 1; e > 0; e--)
            {
                for (int i = 0; i < e; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void InsertionSortEx(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                if(array[partIndex] < array[partIndex - 1])
                {
                    Swap(array, partIndex, partIndex - 1);
                    for (int i = partIndex -1; i > 0; i--)
                    {
                        if (array[i] < array[i-1])
                        {
                            Swap(array, i, i-1);
                        }
                    }
                      
                }
            }
        }
        public static int MinimumSwaps(int[] arr)
        {
            var swapSum = 0;

            for (int iterator = 0; iterator < arr.Length; iterator++)
            {
                while (arr[iterator] != iterator + 1)
                {
                    var swapKey = arr[iterator] - 1;

                    var temp = arr[iterator];

                    arr[iterator] = arr[swapKey];
                    arr[swapKey] = temp;

                    swapSum++;
                }
            }

            return swapSum;
        }
    }
}
