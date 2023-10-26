
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
            Console.WriteLine("Please, enter the upper limit of the range. It should be any natural number bigger then 1:");            
            int upperLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("\r");            

            Program pr = new Program();
            int primeNumberCounter = 0;
            int counter = 1;
            
            /* 
             * Z definicji, liczba piersza jest większa od 1. 
             * Dlatego sprawdzenie czy dana liczba jest piersza, zaczynam od 2.
             * Sprawdzenie kończę na liczbie wpisanej przez usera: upperLimit
             */            
            for (int naturalNumber = 2; naturalNumber <= upperLimit; naturalNumber++)
            {                
                if (pr.IsPrimeNumber(naturalNumber))
                {
                    Console.WriteLine($"Prime number ({counter}): {naturalNumber}");
                    primeNumberCounter++;
                    counter++;
                }
            }            
            Console.WriteLine("\r");
            Console.WriteLine($"Number of prime numbers in range 0 - {upperLimit} : {primeNumberCounter}");            
        }

        bool IsPrimeNumber(int numberToCheck)
        {
            /* 
             * Nie ma potrzeby użycia Floor: (int) Math.Floor(Math.Sqrt(numberToCheck))
             * Rzutowanie na int zaokrągla pierwiastek z liczby w dół.
             */
            int maxDivider = (int) Math.Sqrt(numberToCheck);
            for (int i = 2; i <= maxDivider; i++)
                if (numberToCheck % i == 0) return false;
            return true;
        }


    }
}