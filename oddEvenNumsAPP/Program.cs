using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace OddEvenNmsAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Printing all numbers
            printNums("All numbers: ", nums);

            // Printing only even numbers
            printNums("Even numbers: ", nums.Where(x => isEven(x)));

            printNums("odd numbers: ", nums.Where(x => isOdd(x)));

        }

        // Modified printNums method to handle both the title and the array
        static void printNums(string title, IEnumerable<int> arr)
        {
            Console.WriteLine(title);
            /*
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            */
            // Convert the IEnumerable to a List to use indexing
             var list = arr.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            
            Console.WriteLine();
        }

        static bool isEven(int number) => number % 2 == 0;

        static bool isOdd(int number) => !isEven(number);
    }
}
