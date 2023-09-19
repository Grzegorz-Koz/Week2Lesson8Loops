
/*
 *  Program 5-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("List of powers of numbers from 1-20:");
            Console.WriteLine("\r");

            for (int i = 1; i <= 20; i++) {
                Console.WriteLine($"For number {i}: {Math.Pow(i,3)}");
            }
        }
    }
}