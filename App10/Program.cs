
/*
 *  Program 10-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App10
{
    internal class Program
    {
        static void Main(string[] args)
        {                       
            Console.WriteLine("\r");
            Console.WriteLine("Enter two numbers to find their Least Common Multiple!");
            Console.WriteLine("\r");

            Helpers hlp = new Helpers();
            int numberOfDividings;

            int leastCommonMultiple = 1;

            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            int maxDividerForFirstNumber = (int)Math.Floor(Math.Sqrt(firstNumber));
            int firstNumberToDivide = firstNumber;
            int resultOfDividingFirstNumber = firstNumber;
            int numberOfDividingsFirstNumber = 0;

            Console.WriteLine("Enter first number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int maxDividerForSecondNumber = (int)Math.Floor(Math.Sqrt(secondNumber));
            int secondNumberToDivide = secondNumber;
            int resultOfDividingSecondNumber = secondNumber;
            int numberOfDividingsSecondNumber = 0;

            int maxDivider = (maxDividerForFirstNumber <= maxDividerForSecondNumber) ? maxDividerForSecondNumber : maxDividerForFirstNumber;

            Console.WriteLine("\r");

            for (int i = 2; i <= maxDivider; i++)
            {                
                if (hlp.IsPrimeNumber(i))
                {
                    numberOfDividingsFirstNumber = hlp.GetNumberOfDividings(firstNumberToDivide, i, out resultOfDividingFirstNumber);
                    numberOfDividingsFirstNumber = (firstNumberToDivide != 1) ? numberOfDividingsFirstNumber : 0;

                    numberOfDividingsSecondNumber = hlp.GetNumberOfDividings(secondNumberToDivide, i, out resultOfDividingSecondNumber);
                    numberOfDividingsSecondNumber = (secondNumberToDivide != 1) ? numberOfDividingsSecondNumber : 0;

                    if (numberOfDividingsFirstNumber + numberOfDividingsSecondNumber != 0)
                    {
                        numberOfDividings = (numberOfDividingsFirstNumber <= numberOfDividingsSecondNumber) ? numberOfDividingsSecondNumber : numberOfDividingsFirstNumber;                        
                        leastCommonMultiple = leastCommonMultiple * hlp.powerMe(i, numberOfDividings);                        
                    }
                }

                firstNumberToDivide = resultOfDividingFirstNumber;
                secondNumberToDivide = resultOfDividingSecondNumber;

                // Stop loop when both numbers to divide are equal to 1
                if (firstNumberToDivide + secondNumberToDivide == 2)
                    break;
            }

            if (firstNumberToDivide != 1 || secondNumberToDivide != 1)
            {
                if (firstNumberToDivide == secondNumberToDivide)
                {
                    leastCommonMultiple = leastCommonMultiple * firstNumberToDivide;
                }
                else
                {
                    if (firstNumberToDivide != 1)
                    {
                        leastCommonMultiple = leastCommonMultiple * firstNumberToDivide;
                    }
                    if (secondNumberToDivide != 1)
                    {
                        leastCommonMultiple = leastCommonMultiple * secondNumberToDivide;
                    }
                }
            }
            Console.WriteLine($"Least Common Multiple: {leastCommonMultiple}");
        }
    }




}