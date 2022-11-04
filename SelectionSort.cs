using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingAlgorithms
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };

            SelSort(arr);

            foreach (int i in arr) Console.WriteLine(i); // Print sorted array
            */
            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            SelSort(new int[] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            watch.Stop();

            Console.WriteLine($"Execution time: {watch.Elapsed} ms");
            
            Console.ReadKey(); // Wait until key press before closing program
        }

        static void SelSort(int[] arr)
        {
            // For each position in the array
            // (except the last position, as there are no positions after the last position to check)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int jMin = i; // Assume that the first element is also the minimum

                for (int j = i + 1; j < arr.Length; j++) // For every element after the element being checked
                {
                    if (arr[j] < arr[jMin]) // If this element is less than the current minimum
                    {
                        jMin = j; // This element is the new minimum
                    }
                }

                if (jMin != i) // If the minimum element is not the first element
                {
                    // Swap the first element and the minimum element
                    int temp = arr[jMin];
                    arr[jMin] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
