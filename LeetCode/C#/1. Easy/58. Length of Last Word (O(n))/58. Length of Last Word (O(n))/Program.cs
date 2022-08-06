public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string s = "luffy is still joyboy"
        Console.WriteLine(solution.LengthOfLastWord(s));
    }
    public int LengthOfLastWord(string s)
    {
        int lenghtLastWord = 0;
        int i, count = 0;
        for (i = 0; i < s.Length; i++)
            if (s[i] == ' ')
            {
                if(count!=0)
                    lenghtLastWord = count;
                count = 0;
            }
            else
            {
                count++;
            }
        if (count != 0)
            lenghtLastWord = count;
        return lenghtLastWord;
    }
}