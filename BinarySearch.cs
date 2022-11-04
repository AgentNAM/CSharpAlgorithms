using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingAlgorithms
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine(BinSearch(arr, 5));
            Console.WriteLine(BinSearch(arr, 7));
            Console.WriteLine(BinSearch(arr, 2));
            Console.WriteLine(BinSearch(arr, 10));
            Console.WriteLine(BinSearch(arr, 3)); // Test with elements not in the array
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();
            BinSearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 3);
            watch.Stop();

            Console.WriteLine($"Execution time: {watch.Elapsed} ms");

            Console.ReadKey(); // Wait until key press before closing program
        }

        static int BinSearch(int[] arr, int target)
        {
            int left = 0; // Leftmost index of the interval being searched
            int right = arr.Length - 1; // Rightmost index of the interval being searched

            while (left <= right)
            {
                int mid = (int)Math.Floor((decimal)((left + right) / 2)); // Index of the middle of the interval being searched

                if (arr[mid] < target) // If the element at the middle index is less than the target element
                {
                    left = mid + 1; // Narrow the interval to elements with an index that is greater than the middle index
                }
                else if (arr[mid] > target) // If the element at the middle index is greater than the target element
                {
                    right = mid - 1; // Narrow the interval to elements with an index that is less than the middle index
                }
                else return mid; // If the element at the middle index is equal to the target element, return the middle index
            }

            return -1; // If the search was unsuccessful, return -1
        }
    }
}
