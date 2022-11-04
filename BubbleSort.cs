using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingAlgorithms
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };

            BubSort(arr);

            foreach (int i in arr) Console.WriteLine(i); // Print sorted array
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();
            BubSort(new int[] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            watch.Stop();

            Console.WriteLine($"Execution time: {watch.Elapsed} ms");

            Console.ReadKey(); // Wait until key press before closing program
        }

        static void BubSort(int[] arr)
        {
            bool swapped;
            do
            {
                swapped = false; // Indicate that no swaps have occurred during this pass

                for (int i = 0; i < arr.Length - 1; i++) // Iterate through every adjacent pair
                {
                    if (arr[i] > arr[i + 1]) // If the 1st element in the pair is greater than the 2nd element in the pair
                    {
                        // Swap the pair
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        swapped = true; // Indicate that a swap has occurred during this pass
                    }
                }

            } while (swapped); // If a swap has occurred during the previous pass, do another pass
        }
    }
}
