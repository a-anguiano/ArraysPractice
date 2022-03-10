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

            Console.WriteLine($"{threeOfAKind}");       //how can I see this other than by indexing?

            //3D Int array
            int[,,] valueCube = {
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            },
            {
                { 11, 12, 13 },
                { 14, 15, 16 },
                { 17, 18, 19 }
            },
            {
                { 21, 22, 23 },
                { 24, 25, 26 },
                { 27, 28, 29 }
            }
            };

            Console.WriteLine($"{valueCube}");

        }
    }
}
