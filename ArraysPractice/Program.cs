using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
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
