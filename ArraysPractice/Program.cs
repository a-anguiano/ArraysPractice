using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //using while loop with arrays and also indexing
            string[] elements = { "Hydrogen", "Helium", "Lithium", "Beryllium" };

            // loop from front to back
            int index = 0; // start of array
            while (index < elements.Length)
            {
                Console.WriteLine($"The element at index {index} is {elements[index]}");
                index++;
            }

         
        }
    }
}
