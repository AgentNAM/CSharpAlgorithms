using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingAlgorithms
{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[] { 1, 2, 4, 5, 7, 9, 10, 12 };

            Console.WriteLine(LinSearch(arr, 5));
            Console.WriteLine(LinSearch(arr, 7));
            Console.WriteLine(LinSearch(arr, 2));
            Console.WriteLine(LinSearch(arr, 10));
            Console.WriteLine(LinSearch(arr, 3)); // Test with elements not in the array
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();
            LinSearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 3);
            watch.Stop();

            Console.WriteLine($"Execution time: {watch.Elapsed} ms");

            Console.ReadKey(); // Wait until key press before closing program
        }

        static int LinSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++) // Iterate through each element in the array
            {
                if (arr[i] == target) return i; // If the element being searched matches the target, return the index
            }
            return -1; // If none of the elements being searched match the target, return -1
        }
    }
}
