using System;

namespace insertion_sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1000, 1, 25, 99 };

            PrintArray(x);
            MakeLine();
            InsertionSort(x);
            MakeLine();
            PrintArray(x);
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    arr[j + 1] = temp;
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        public static void MakeLine()
        {
            Console.WriteLine();
            for (int i = 0; i < 25; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
