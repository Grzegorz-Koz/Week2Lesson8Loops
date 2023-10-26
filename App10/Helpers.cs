
/*
 *  Program 10-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App10
{
    public class Helpers
    {
        
        public int powerMe(int basisOfPower, int exponent)
        {
            int returnNumber = basisOfPower;
            while (exponent > 1)
            {
                returnNumber = returnNumber * basisOfPower;                
                exponent -= 1;
            }
            return returnNumber;
        }
        
        public bool IsPrimeNumber(int numberToCheck)
        {
            int maxDivider = (int) Math.Sqrt(numberToCheck);
            for (int i = 2; i <= maxDivider; i++)
                if (numberToCheck % i == 0) return false;
            return true;
        }

        /*
         * Funkcja zwraca liczbę: 
         * 0 - jeśli "divider" nie jest dzielnikiem liczby "numberToDivide"
         * k - jeśli "divider" jest dzielnikiem liczby "numberToDivide", gdzie numberToDivide = k * divider * resultOfDividing
         * gdzie resultOfDividing nie jest podzielny przez divider.
         */
        public int GetNumberOfDividings(int numberToDivide, int divider, out int resultOfDividing)
        {
            int numberOfDividings = 0;
            resultOfDividing = numberToDivide;
            bool tryToDivide = true;            
            do
            {
                if (resultOfDividing % divider == 0)
                {
                    resultOfDividing = resultOfDividing / divider;
                    numberOfDividings++;
                }
                else
                {
                    tryToDivide = false;
                }
            }
            while (tryToDivide);

            return numberOfDividings;
        }
    
    
    
    
    }

}