using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingAlgorithms
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };

            QckSort(arr, 0, arr.Length - 1);

            foreach (int i in arr) Console.WriteLine(i); // Print sorted array
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();
            QckSort(new int[] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            watch.Stop();

            Console.WriteLine($"Execution time: {watch.Elapsed} ms");

            Console.ReadKey(); // Wait until key press before closing program
        }

        static void QckSort(int[] arr)
        {
            QckSort(arr, 0, arr.Length - 1);
        }

        static void QckSort(int[] arr, int low, int high)
        {
            if (low < high) // Ensure indices are in the correct order
            {
                int pi = Partition(arr, low, high); // Partition array and get pivot index

                // Sort the two partitions
                QckSort(arr, low, pi - 1); // Sort left side of the pivot
                QckSort(arr, pi + 1, high); // Sort right side of the pivot
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Choose last element as the pivot

            int i = low - 1; // Temporary pivot index

            for (int j = low; j <= high - 1; j++)
            {
                // If the current element is less than or equal to the pivot
                if (arr[j] < pivot)
                {
                    i++; // Move the temporary pivot index forward

                    // Swap the current element with the element found at the temporary pivot index
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Move the pivot element to the correct pivot position (between the smaller and larger elements)
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1; // Return the pivot index
        }
    }
}
