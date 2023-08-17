
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






//1071.Greatest Common Divisor of Strings
//Easy

//4081

//772

//Add to List

//Share
//For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).

//Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.



//Example 1:

//Input: str1 = "ABCABC", str2 = "ABC"
//Output: "ABC"
//Example 2:

//Input: str1 = "ABABAB", str2 = "ABAB"
//Output: "AB"
//Example 3:

//Input: str1 = "LEET", str2 = "CODE"
//Output: ""



//Constraints:

//1 <= str1.length, str2.length <= 1000
//str1 and str2 consist of English uppercase letters.
//Accepted
//231,612
//Submissions
//435,708