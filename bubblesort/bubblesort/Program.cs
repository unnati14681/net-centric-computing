using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            // Traverse through all array elements
            for (int i = 0; i < n - 1; i++)
            {
                // Last i elements are already sorted, so we ignore them
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the element found is greater than the next element
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Method to print an array
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            // Sample array to sort
            int[] arr = { 64, 25, 12, 22, 11 };

            Console.WriteLine("Original array:");
            PrintArray(arr);

            // Call BubbleSort method
            BubbleSort(arr);

           Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }
    
}
}
