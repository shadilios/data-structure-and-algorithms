using System;

namespace Merge_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 5, 2, 3, 9 };

            MergeSort(x);


            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            
        }



        static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = arr[0..mid];
                int[] right = arr[mid..n];

                MergeSort(left);

                MergeSort(right);

                Merge(left, right, arr);

            }

            return arr;
        }

        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;


            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    j = j + 1;
                }

                k = k + 1;
            }

            if (i == left.Length)
            {
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;
        }
        

    }









}
