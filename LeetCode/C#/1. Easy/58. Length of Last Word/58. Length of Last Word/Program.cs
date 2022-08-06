public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string s = "dsfs d sdf sdf sdf sdfs dffff";
        Console.WriteLine(solution.LengthOfLastWord(s));
    }
    public int LengthOfLastWord(string s)
    {
        int lastSpaceIndex = 0, i, count = 0 ;
        for (i = 0; i < s.Length - 1; i++)
            if (s[i] == ' ' && s[i + 1] != ' ') 
                lastSpaceIndex = i+1;
        i = lastSpaceIndex;
        while (i < s.Length && s[i] != ' ')
        {
            count++;
            i++;
        }    
        return count;
    }
}