
/*
 *  Program 7-my z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 8 – Pętle"
 *  
 */

namespace App7
{
    public class DiamondParts
    {
        public string CreateSpacePart(int numberOfSpaces)
        {
            string spacePart = "";
            for (int i = 0; i < numberOfSpaces; i++)
            {                
                spacePart += " ";
            }
            return spacePart;
        }

        public string CreateStarPart(int numberOfStars)
        {
            string starPart = "";
            for (int i = 0; i < numberOfStars; i++)
            {                
                starPart += "*";
            }
            return starPart;
        }


        public int getHalfOfLongerDiagonal(int shorterDiagonal, bool isOddNumber)
        {
            int supportingNumber = isOddNumber ? 1 : 0;
            return shorterDiagonal - (shorterDiagonal - supportingNumber) / 2;
        }



        public string CreateSingleLevelOfDiamond(int levelOfDiamond, int shorterDiagonal, bool isOddNumber)
        {
            int lengthOfSpacePart;
            int lengthOfStarPart;

            lengthOfStarPart = (isOddNumber) ? (2 * levelOfDiamond - 1) : (2 * levelOfDiamond);
            lengthOfSpacePart = (shorterDiagonal - lengthOfStarPart) / 2;

            return CreateSpacePart(lengthOfSpacePart) + CreateStarPart(lengthOfStarPart)  + CreateSpacePart(lengthOfSpacePart);
        }

    }
}