public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string s = "dsahjpjauf";
        string[] words = new string[] { "ahjpjau","ja","ahbwzgqnuk","tnmlanowax" };
        Console.WriteLine(solution.NumMatchingSubseq(s, words));
    }
    public int NumMatchingSubseq(string s, string[] words)
    {
        bool isSubsequence;
        bool canContinue;
        int countSubsequence = 0;
        foreach (string word in words)
        {
            isSubsequence = true;
            int n = 0;
            for (int i = 0; i < word.Length; i++)
            {
                canContinue = false;
                for (int j = n; j < s.Length; j++)
                {
                    if (word[i] == s[j])
                    {
                        n = j + 1;
                        canContinue = true;
                        break;
                    }
                }
                if (!canContinue)
                {
                    isSubsequence = false;
                    break;
                }
            }
            if (!isSubsequence) 
                continue;
            countSubsequence++;
        }
        return countSubsequence;
    }
}