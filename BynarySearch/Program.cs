using System;

namespace Sourch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int target = 7;

            Console.WriteLine("Binary Search (Iterative): " + Sourch.BS(arr, target));
            Console.WriteLine("Binary Search (Recursive): " + Sourch.BS(arr, target, 0, arr.Length - 1));

            Console.WriteLine("Lower Bound (Iterative): " + Sourch.LowerBound(arr, target));
            Console.WriteLine("Lower Bound (Recursive): " + Sourch.LowerBound(arr, target, 0, arr.Length - 1));

            Console.WriteLine("Upper Bound (Iterative): " + Sourch.UpperBound(arr, target));
            Console.WriteLine("Upper Bound (Recursive): " + Sourch.UpperBound(arr, target, 0, arr.Length - 1));
        }
    }
}

