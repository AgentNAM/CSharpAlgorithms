using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingAlgorithms
{
    internal class MergeSort
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };

            MrgSort(arr);

            foreach (int i in arr) Console.WriteLine(i); // Print sorted array
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();
            MrgSort(new int[] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            watch.Stop();

            Console.WriteLine($"Execution time: {watch.Elapsed} ms");

            Console.ReadKey(); // Wait until key press before closing program
        }

        // Allow MrgSort() to be called without specifying left and right parameters
        static void MrgSort(int[] arr)
        {
            MrgSort(arr, 0, arr.Length - 1);
        }

        static void MrgSort(int[] arr, int l, int r)
        {
            if (l < r) // Only sort if the array size is more than 1
            {
                int m = l + ((r - l) / 2); // Find the midpoint

                MrgSort(arr, l, m); // Sort left subarray
                MrgSort(arr, m + 1, r); // Sort right subarray

                MrgMerge(arr, l, m, r); // Merge the two subarray
            }
        }

        static void MrgMerge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1; // Left subarray size
            int n2 = r - m; // Right subarray size

            int[] L = new int[n1]; // Temp left subarray
            int[] R = new int[n2]; // Temp right subarray

            int i; // Initial index of left subarray
            int j; // Initial index of right subarray

            // Copy data to temp subarrays
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            // Reset initial indices
            i = 0;
            j = 0;

            int k = l; // Initial index of merged subarray array

            while (i < n1 && j < n2) // While there is at least one element in each temp subarray
            {
                // Compare the smallest elements in each temp subarray, then add the smallest of the two to the merged subarray array
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy any remaining elements of L[]
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy any remaining elements of R[]
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
