using System;
namespace Sort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            Sort.HeapSort(arr);
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}