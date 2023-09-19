
/*
 *  Program 1-szy z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 * 
 */

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The application displays how many prime numbers there are in the given range (e.g. 0 - 100).");
            Console.WriteLine("Please enter the upper limit of the range. It should be any natural number bigger then 1:");            
            int upperLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("\r");            

            bool isPrimeNumber;
            int primeNumberCounter = 0;
            int counter = 1;
            for (int naturalNumber = 2; naturalNumber <= upperLimit; naturalNumber++)
            {
                isPrimeNumber = true;                
                for (int divider = 2; divider <= (naturalNumber - 1); divider++)
                {                    
                    if ((naturalNumber % divider) == 0)
                    {
                        isPrimeNumber = false;
                    }
                    if (!isPrimeNumber)
                    {
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine($"Prime number ({counter}): {naturalNumber}");
                    primeNumberCounter = primeNumberCounter + 1;
                    counter = counter  + 1;
                }
            }
            
            Console.WriteLine("\r");
            Console.WriteLine($"Number of prime numbers in range 0 - {upperLimit} : {primeNumberCounter}");            

        }
    }
}