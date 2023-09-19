
/*
 *  Program 7-my z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

using System.Security.Cryptography;

namespace App7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("Enter the length of the shorter diagonal of the diamond (>= 3).");
            Console.WriteLine("(For even numbers, the diamond will be \"blunt\".)");
            Console.WriteLine("\r");
            Console.WriteLine("Enter your length:");
            int shorterDiagonal = int.Parse(Console.ReadLine());
            bool isOddNumber = (shorterDiagonal % 2 != 0) ? true : false;
            DiamondParts dp = new DiamondParts();
            int halfOfLongerDiagonal = dp.getHalfOfLongerDiagonal(shorterDiagonal, isOddNumber);

            Console.WriteLine("\r");
            Console.WriteLine("Yur diamond:");
            Console.WriteLine("\r");

            // Upper part of the diamond
            for (int i = 1; i <= halfOfLongerDiagonal; i++)
            {
               Console.WriteLine(dp.CreateSingleLevelOfDiamond(i, shorterDiagonal, isOddNumber));
            }

            // Bottom part of the diamond
            for (int i = halfOfLongerDiagonal-1; i >= 1; i--)
            {
                Console.WriteLine(dp.CreateSingleLevelOfDiamond(i, shorterDiagonal, isOddNumber));
            }
        }
    }
}