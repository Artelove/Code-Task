public class Solution
{
    static void Main()
    {
        string s = "XXXIV";
        int charCounter = 0;
        int digitSum = 0;
        string currentChar;
        string currentTwoChars;
        Dictionary<string, int> values = new Dictionary<string, int>()
        {
            {"I", 1 },
            {"V", 5 },
            {"X", 10 },
            {"L", 50 },
            {"C", 100 },
            {"D", 500 },
            {"M", 1000 },
            {"IV", -2 },
            {"IX", -2 },
            {"XL", -20},
            {"XC", -20},
            {"CD", -200},
            {"CM", -200},
        };
        while (charCounter <= s.Length-1)
        {
            currentChar = s[charCounter].ToString();
            if (charCounter + 1 <= s.Length -1 ) { 
                currentTwoChars = s[charCounter].ToString() + s[charCounter + 1].ToString();
                digitSum += values.GetValueOrDefault(currentTwoChars);
             }
            digitSum += values.GetValueOrDefault(currentChar);
           
            charCounter++;
        }
        Console.WriteLine(digitSum);
        //return digitSum;
    }
}