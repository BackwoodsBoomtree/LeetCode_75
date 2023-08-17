
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        string result = "";
        string testResultLong = "";
        string testResultShort = "";
        string longString = str1;
        string shortString = str2;
        int lLength = str1.Length;
        int sLength = str2.Length;

        if (str1.Length < str2.Length)
        {
            longString = str2;
            shortString = str1;
            lLength = longString.Length;
            sLength = shortString.Length;
        }

        // Get GCD
        while (lLength != 0 && sLength != 0)
        {
            if (lLength > sLength)
                lLength %= sLength;
            else
                sLength %= lLength;
        }

        int gcd = lLength | sLength;

        for (int i = 0; i < gcd; i++)
        {
            if (shortString[i] == longString[i])
            {
                result += shortString[i];
            }
        }

        if (result == "")
        {
            return result;
        }
        else
        {
            for (int i = 0; i < longString.Length / result.Length; i++)
            {
                testResultLong += result;
            }

            if (testResultLong == longString)
            {
                for (int i = 0; i < shortString.Length / result.Length; i++)
                {
                    testResultShort += result;
                }
                if (testResultShort == shortString)
                {
                    return result;
                }
                else
                { 
                    return "";
                }
            }
            else
            {
                result = "";
            }
        }
        return result;
    }
}
