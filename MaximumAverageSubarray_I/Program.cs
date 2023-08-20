var test = new Solution();

int[] myArray = { 1, 12, -5, -6, 50, 3 };
int myK = 4;
var testResult = test.FindMaxAverage(myArray, myK);

Console.WriteLine(testResult);
Console.ReadKey();

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double[] doubleNums = new double[nums.Length];
        List<double> doubleList = new List<double>();

        // Cast array of int to list of doubles
        for (int i = 0; i < nums.Length; i++)
        {
            doubleNums[i] = Convert.ToDouble(nums[i]);
        }

        if (nums.Length == 1)
        {
            return doubleNums[0];
        }

        for (int i  = 0; i < doubleNums.Length - k + 1; i++)
        {
            double loopAverage = doubleNums[i..(i + k )].Average();
            doubleList.Add(loopAverage);
        }

        return doubleList.Max();
    }
}