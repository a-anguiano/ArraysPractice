using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array with 7 elements, indexes 0 to 6, all values are null
            string[] names = new string[7];

            // declare an array with 3 elements, indexes 0 to 2, all values are 0
            int[] ints = new int[3];

            // declare an array with 3 strings, indexes 0 to 2
            string[] primary = { "red", "yellow", "blue" };

            // declare an array with 4 integers, indexes 0 to 3
            int[] nums = { 5, 10, 15, 20 };

            //using while loop with arrays and also indexing
            string[] elements = { "Hydrogen", "Helium", "Lithium", "Beryllium" };

            // loop from front to back
            int index = 0; // start of array
            while (index < elements.Length)
            {
                Console.WriteLine($"The element at index {index} is {elements[index]}");
                index++;
            }

            //Using a for loop to index and determine the maximum
            int[] numbers = { 3, -5, 10, 3, 12, 20, 5 };

            // The first element is the current max
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"The max value is {max}");

            //Using a for loop to index and determine minimum
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            
            Console.WriteLine($"The min value is {min}");
        }
    }
}
