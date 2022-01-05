﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortType.Test
{
    [TestFixture]
    public class SortingTests
    {
        [Test]
        public void BubbleSort_ValidInput_SortInput()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 1,-2 };
            samples[2] = new[] { 1,-2,-3 };
            samples[3] = new[] { 1, 4,5,-7 };
            samples[4] = new[] { 1, 2, 4 };
            samples[5] = new[] { 1, -2,-5, 5, 6 };
            samples[6] = new[] { 1, 4, 5,6 ,7, -9,-1 };
            samples[7] = new[] { 1, -2, 6, 7,-8 };
            samples[8] = new[] { 1, -4, 3, 6,-6, 7,8, 9, 0 };
        }
    }
}