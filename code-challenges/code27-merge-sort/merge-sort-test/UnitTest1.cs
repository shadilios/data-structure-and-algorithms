using System;
using Xunit;
using Merge_Sort;

namespace merge_sort_test
{
    public class UnitTest1
    {
        [Fact]
        public void ExpectedOutcome()
        {
            int[] x = new int[] { 5, 2, 3, 9 };

            int[] expected = new int[] { 2, 3, 5, 9 };

            Assert.Equal(expected, Program.MergeSort(x));
        }


        [Fact]
        public void ExpectedFailure()
        {
            int[] x = new int[] { 5, 2, 3, 9 };

            int[] notExpected = new int[] { 3, 2, 9, 5 };

            Assert.NotEqual(notExpected, Program.MergeSort(x));
        }
    }
}
