Solution test = new Solution();
var testResult = test.ReverseVowels("racecar");

Console.WriteLine(testResult);
Console.ReadKey();

public class Solution
{
    public string ReverseVowels(string s)
    {
        if (!string.IsNullOrWhiteSpace(s))
        {
            string result = "";
            string vowelsInString = "";
            List<int> vowelsIndex = new();
            int vowelCounter = 0;

            // Identify vowels and their location
            for (int i = 0; i < s.Length; i++)
            {
                if ("aeiouAEIOU".IndexOf(s[i]) >= 0)
                {
                    vowelsInString += s[i];
                    vowelsIndex.Add(i);
                }
            }

            if (vowelsInString.Length <= 0)
            {
                return s;
            }

            else if (vowelsInString.Length > 1)
            {
                // Insert back into string in reverse order
                string reverseVowels = new(vowelsInString.Reverse().ToArray());
                for (int i = 0; i < s.Length; ++i)
                {
                    if (vowelCounter < vowelsInString.Length)
                    {
                        if (vowelsIndex[vowelCounter] == i)
                        {
                            result += reverseVowels[vowelCounter];
                            vowelCounter++;
                        }
                        else
                        {
                            result += s[i];
                        }
                    }
                    else
                    {
                        result += s[i];
                    }
                }
                return result;
            }
        }
        return s;
    }
}