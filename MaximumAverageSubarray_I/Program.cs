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
            if (nums[i] > -10E4 && nums[i] <= 10E4)
            {
                doubleNums[i] = Convert.ToDouble(nums[i]);
            }
            else
            {
                return 0;
            }
        }

        if (nums.Length <= 1 || k < 1 || k > nums.Length || nums.Length > 10E5)
        {
            return doubleNums[0];
        }

        for (int i  = 0; i < doubleNums.Length - k + 1; i++)
        {
            // Do not need to average as the greatest sum computes faster
            double loopSum = doubleNums[i..(i + k )].Sum();
            doubleList.Add(loopSum);
        }

        return doubleList.Max() / k;
    }
}