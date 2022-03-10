using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] familyAges = new int[3][];

            familyAges[0] = new int[] { 44, 44, 13, 16, 20 };
            familyAges[1] = new int[] { 32, 34, 3, 5 };
            familyAges[2] = new int[] { 55, 53 };

            for (int i = 0; i < familyAges.Length; i++)
            {
                Console.WriteLine($"Element {i}");
                for (int j = 0; j < familyAges[i].Length; j++)
                {
                    Console.WriteLine($"{j}:{familyAges[i][j]}");
                }
            }
        }
    }
}
