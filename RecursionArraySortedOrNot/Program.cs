using System;

namespace RecursionArraySortedOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray1 = { 3, 2, 6, 70, 1, 65, 698, 2, 31, 45 };
            int[] iArray2 = { 1, 2, 6, 70, 76, 963, 7952, 12366, 23548};
            Console.WriteLine("Array is sorted = {0}", SortedOrNot(iArray1, iArray1.Length - 1));
            Console.WriteLine("Array is sorted = {0}", SortedOrNot(iArray2, iArray2.Length - 1));
        }

        #region If Array is Array Sorted
        //Checking if an array is sorted recursively
        static bool SortedOrNot(int[] arr, int iMaxIndex)
        {
            if (iMaxIndex == 0)
            {
                return true;
            }

            return arr[iMaxIndex - 1] <= arr[iMaxIndex] && SortedOrNot(arr, iMaxIndex - 1);
        }

        #endregion
    }
}
