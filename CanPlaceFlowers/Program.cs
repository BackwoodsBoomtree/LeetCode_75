public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int newFlowerCounter = 0;

        if (flowerbed.Length == 1 && flowerbed[0] == 0)
            {
            return true;
            }

        for (int i = 0; i < flowerbed.Length - 1; i++)
        {
            // If two open spots at beginning
            if (
                i == 0 && 
                flowerbed[i] == 0 && 
                flowerbed[i + 1] == 0)
            {
                newFlowerCounter += 1;
            }

            // If two open spots at the end
            else if (i == flowerbed.Length - 2)
            {
                if (
                    flowerbed[i] == 0 && 
                    flowerbed[i + 1] == 0)
                {
                    newFlowerCounter += 1;
                }
            }

            // If three open spots in a row
            else if (
                i < flowerbed.Length - 2 && 
                flowerbed[i] == 0 &&
                flowerbed[i + 1] == 0 &&
                flowerbed[i + 2] == 0)
            {
                newFlowerCounter += 1;
                i += 1;
            }
        }
        if (n <= newFlowerCounter)
        {
            return true;
        }
        else { return false; }
    }
}