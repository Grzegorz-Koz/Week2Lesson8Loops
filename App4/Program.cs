
/*
 *  Program 4-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("Enter the largest number after which you want to finish building the pyramid.");
            Console.WriteLine("(Remember that the entered number may not be displayed as the last one at the base of the pyramid.)");
            Console.WriteLine("\r");
            Console.WriteLine("Enter your number:");

            int pyramidMax = int.Parse(Console.ReadLine());
            string pyramidFloor = "";
            int firstNumberOfFloor = 1;
            int numberOfCharacters = 1;
            int enlargedNumber = 0;
            Program pyramid = new Program();

            Console.WriteLine("\r");
            Console.WriteLine("There is your pyramid:");
            Console.WriteLine("\r");

            bool lastFloor = false;
            while (!lastFloor)
            {                
                pyramidFloor = pyramid.getPyramidFloor(firstNumberOfFloor, numberOfCharacters, pyramidMax, out lastFloor);
                Console.WriteLine(pyramidFloor);
                firstNumberOfFloor = firstNumberOfFloor + numberOfCharacters;
                numberOfCharacters = numberOfCharacters + 1;
            }
       
        }

        string getPyramidFloor(int firstNumberOfFloor, int numberOfCharacters, int pyramidMax, out bool lastFloor)
        {
            lastFloor = false;
            string pyramidFloor = firstNumberOfFloor.ToString();
            int enlargedNumber = firstNumberOfFloor;
            for (int i = 1; i <= numberOfCharacters-1; i++)
            {
                enlargedNumber = enlargedNumber + 1;
                pyramidFloor = pyramidFloor + " " + enlargedNumber;
                if (enlargedNumber >= pyramidMax)
                {
                    lastFloor = true;
                }
            }
            return pyramidFloor;
        }
    }        

    }


