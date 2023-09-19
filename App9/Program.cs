
/*
 *  Program 9-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("Enter the integer you want to convert to binary:");
            double numberToConvert = double.Parse(Console.ReadLine());
            Console.WriteLine("\r");
            double number = numberToConvert;
            string binaryPart = string.Empty;
            string binaryNumber = string.Empty;
            do
            {
                binaryPart = (number % 2 == 1) ? "1": "0";                                
                binaryNumber = binaryPart + binaryNumber;
                number = Math.Floor(number / 2);
            }
            while (number != 0);

            Console.WriteLine($"Your Binary Number: {binaryNumber}");
        }
    }
}