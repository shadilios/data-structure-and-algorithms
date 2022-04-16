using System;

namespace array_binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 11, 22, 33, 44, 55, 66, 77 };
            
            //exists and outputs 4
            int key = 55;
            Console.WriteLine(BinarySearch(myArray, key));


            //doesn't exists and outputs -1
            int key2 = 99;
            Console.WriteLine(BinarySearch(myArray, key2));

        }

        static int BinarySearch(int[] sortedArr, int key)
        {
            //set 2 pointers left and right, and search values between them
            //and change left and right values each time we don't find the element


            //Assign left and right value
            int left = 0;
            int right = sortedArr.Length - 1;

            //default value if it doesn't exist
            int myIndex = -1;

            //search if the value "key" is in the array
            //if it exists in the array, return its index
            //if not return -1

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (key == sortedArr[middle])
                {
                    myIndex = middle;
                    break;
                }
                else if (key > sortedArr[middle])
                {
                    left = middle + 1;
                }
                else if (key < sortedArr[middle])
                {
                    right = middle - 1;
                }

            }

            return myIndex;

        }
    }
}