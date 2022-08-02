public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string haystack = "a";
        string needle = "a";
        Console.WriteLine(solution.StrStr(haystack, needle));
    }
    public int StrStr(string haystack, string needle)
    {
        int startIndex = -1;
        if (needle.Length == 0) return 0; 
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0]) {
                if (i + needle.Length > haystack.Length)
                    continue;
                startIndex = i;
                for (int j = 1; j < needle.Length; j++)
                    if (haystack[i + j] != needle[j])
                        startIndex = -1;
                if (startIndex == -1)
                    continue;
                else return startIndex;
            }
        }
        return startIndex;
    }
}