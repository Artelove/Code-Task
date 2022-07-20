public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string[] strs = new string[] { "a" };
        Console.WriteLine(solution.LongestCommonPrefix(strs));
    }
    public string LongestCommonPrefix(string[] strs)
    {
        int min = strs[0].Length;
        string longestCommonPrefix = "";
        char currentChar = ' ';
        foreach (string str in strs)
            if (str.Length < min)
                min = str.Length;

        for (int i = 0; i < min; i++)
        {
            currentChar = strs[0][i];
            foreach (string str in strs)
            {
                if (str[i] != currentChar)
                    return longestCommonPrefix;
            }
            longestCommonPrefix += currentChar;
        }
        return longestCommonPrefix;
    }
}