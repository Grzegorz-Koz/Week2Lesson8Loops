
/*
 *  Program 3-ci z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 * 
 */

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many first numbers of the Fibonacci sequence would you like to display? (min value 2):");
            int numberOfTerms = int.Parse(Console.ReadLine());
            
            int counter = 1;
            int fibonacciNumberPrevious = 0;
            int fibonacciNumber = 1;
            int nextFibonacciNumber;

            Console.WriteLine("\r");
            Console.WriteLine($"List of {numberOfTerms} Fibonacci numbers:");
            Console.WriteLine("\r");
            for (int i = 0; i <= (numberOfTerms - 1); i++)
            {
                if (i < 2) {
                    switch (i)
                    {
                        case 0:                            
                            Console.WriteLine($"Fibonacci number ({counter}): {fibonacciNumberPrevious}");
                            break;
                        case 1:                            
                            Console.WriteLine($"Fibonacci number ({counter}): {fibonacciNumber}");
                            break;
                    }
                } 
                else 
                {
                    nextFibonacciNumber = fibonacciNumberPrevious + fibonacciNumber;                    
                    Console.WriteLine($"Fibonacci number ({counter}): {nextFibonacciNumber}");
                    fibonacciNumberPrevious = fibonacciNumber;
                    fibonacciNumber = nextFibonacciNumber;
                }
                counter += 1;
            }            
        }
    }
}