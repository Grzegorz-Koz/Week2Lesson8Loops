
/*
 *  Program 2-gi z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 * 
 */

using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the upper limit of the range in which you are looking for even numbers:");
            int upperLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("\r");
            Console.WriteLine($"Even numbers in the range of 0 - {upperLimit}:");
            int number = 0;
            bool isEvenNumber;
            int counter = 1;
            do
            {
                isEvenNumber = (number % 2 == 0) ? true : false;
                if (isEvenNumber)
                {
                    Console.WriteLine($"Even number ({counter}): {number}");                    
                    counter += 1;
                }
                number += 1;                
            }
            while (number <= upperLimit);
            
        }
    }
}