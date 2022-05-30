using System;

namespace quick_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 2, 3 };

            var newArr = QuickSort(array, 0, array.Length);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }



        /// <summary>
        /// Swaps between elements, just to avoid code repition
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        /// <summary>
        /// To Split
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int swapIndex = start;

            for (int i = start + 1; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    swapIndex++;
                    Swap(arr, i, swapIndex);
                }
            }
            Swap(arr, start, swapIndex);

            return swapIndex;
        }

        /// <summary>
        /// Sorting function itself
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int[] QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSort(arr, start, pivot);
                QuickSort(arr, pivot + 1, end);
            }

            return arr;
        }

    }
}
