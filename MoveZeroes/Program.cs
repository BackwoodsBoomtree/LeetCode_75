// This version runs out of memory with massive arrays

Solution test = new();
int[] testArray = { 0,1,0,3,12 };
int[] testArray2 = { 0, 0, 1 };
int[] testArray3 = { 1, 0, 0, 1 };
test.MoveZeroes(testArray3);

testArray3.ToList().ForEach(element => Console.Write($"{element}"));
Console.ReadKey();

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // Test if all zeros
        var isAllZero = nums.All(o => o == 0);

        if (nums.Length > 1 && isAllZero == false)
        {
            int i = 0;
            int slideCounter = 0;
            while (i < nums.Length - slideCounter)
            {
                if (nums[i] == 0)
                {
                    for (int j = 0; j < nums[i..].Length - 1; j++)
                    {
                        nums[i + j] = nums[i + j + 1];
                    }
                    nums[^1] = 0;
                    slideCounter++;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}