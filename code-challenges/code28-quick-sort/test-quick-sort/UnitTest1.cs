using System;
using Xunit;
using quick_sort;



namespace test_quick_sort
{
    public class UnitTest1
    {
        [Fact]
        public void ExpectedOutcome()
        {
            int[] array = { 4, 1, 2, 3 };

            int[] expected = { 1, 2, 3, 4 };

            int[] newArray = Program.QuickSort(array, 0, array.Length);

            Assert.Equal(expected, newArray);

        }


        [Fact]
        public void ExpectedFailure()
        {
            int[] array = { 4, 1, 2, 3 };

            int[] notExpected = { 1, 3, 2, 4 };

            int[] newArray = Program.QuickSort(array, 0, array.Length);

            Assert.NotEqual(notExpected, newArray);
        }
    }
}
