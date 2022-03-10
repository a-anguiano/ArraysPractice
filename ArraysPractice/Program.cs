using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D String array
            string[,] threeOfAKind = {
                { "Strawberry", "Blueberry", "Gooseberry" },
                { "Red", "Yellow", "Blue" },
                { "Atlantic", "Pacific", "Indian" }
            };

            string element = threeOfAKind[1, 2];

            Console.WriteLine(element);            // Blue
            Console.WriteLine(threeOfAKind[2, 0]); // Atlantic

        }
    }
}
