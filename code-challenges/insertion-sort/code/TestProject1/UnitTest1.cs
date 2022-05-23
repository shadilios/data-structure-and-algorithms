using System;
using Xunit;
using insertion_sort;

namespace TestProject1
{
    public class UnitTest1
    {
        //correct:
        int[] correct = new int[] { 1, 25, 99, 1000 };

        //wrong:
        int[] wrong = new int[] { 1000, 99, 25, 1 };





        [Fact]
        public void TestCorrect()
        {
            int[] x = new int[] { 1, 99, 25, 1000 };

            Program.InsertionSort(x);

            Assert.Equal(correct, x);
        }

        [Fact]
        public void TestWrong()
        {
            int[] x = new int[] { 1, 99, 25, 1000 };

            Program.InsertionSort(x);


            Assert.NotEqual(wrong, x);
        }


    }
}
