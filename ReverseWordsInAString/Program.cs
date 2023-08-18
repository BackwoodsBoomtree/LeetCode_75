
Solution test = new();
var testResult = test.ReverseWords("okay how is that");

Console.WriteLine(testResult);
Console.ReadKey();

public class Solution
{
    public string ReverseWords(string s)
    {
        string result = "";

        string[] wordsArray = s.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < wordsArray.Length; i++)
        {
            result += wordsArray[^(i+1)] + " ";
        }

        // Remove extra white space
        result = result.Remove(result.Length - 1);

        return result;
    }
}