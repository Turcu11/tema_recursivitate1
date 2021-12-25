using System;

namespace Recursivitate
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Please fill in the array.");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Element of {i} = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintArrayWithRecursionMethod(array, 0, n);
        }

        public static void PrintArrayWithRecursionMethod(int[] array, int start, int end)
        {
            if(start >= end)
            {
                return;
            }
            Console.WriteLine($"Array = {array[start]}");
            PrintArrayWithRecursionMethod(array, start + 1, end);
        }
    }
}