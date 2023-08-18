// This version was accepted and was faster than 82%
Solution test = new();
int[] testArray = { 0, 1, 0, 3, 12 };
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
            List<int> noZeroes = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) { noZeroes.Add(nums[i]); }
            }

            for (int i = 0; i < noZeroes.Count(); i++)
            {
                nums[i] = noZeroes[i];
            }

            int numberOfZeroes = nums.Length - noZeroes.Count();

            for (int i = 0; i < numberOfZeroes; i++)
            {
                nums[i + noZeroes.Count()] = 0;
            }
        }
    }
}