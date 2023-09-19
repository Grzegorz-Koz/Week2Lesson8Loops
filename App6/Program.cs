
/*
 *  Program 6-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of the numbers to be summed:");
            Console.WriteLine("\r");

            int[,] fractions = new int[20,2];
            float sumOfFractions = 0;

            float fraction;
            float numeratorOfFraction;
            float denominatorOfFraction;

            for (int i = 0; i < 20; i++)
            {
                fractions[i, 0] = 1; // numerator
                fractions[i, 1] = i + 1; // denominator
                
                numeratorOfFraction = (float)fractions[i, 0];
                denominatorOfFraction = (float)fractions[i, 1];
                
                fraction = numeratorOfFraction / denominatorOfFraction;                
                sumOfFractions += fraction;

                Console.WriteLine($"{fractions[i, 0]} / {fractions[i, 1]} = {fraction}");                
            }

            Console.WriteLine("\r");
            Console.WriteLine($"The sum of the above numbers is: {sumOfFractions}");
        }
    }
}