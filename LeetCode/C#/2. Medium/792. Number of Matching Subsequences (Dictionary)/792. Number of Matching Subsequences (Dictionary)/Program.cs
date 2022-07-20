public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string s = "dsahjpjauf";
        string[] words = new string[] { "ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax" };
        Console.WriteLine(solution.NumMatchingSubseq(s, words));
    }
    public int NumMatchingSubseq(string s, string[] words)
    {
        int count = 0;
        var wordCount = new Dictionary<string, int>();
        var isSubSequenceConfirmedEarlier = new Dictionary<string, bool>();

        foreach (var word in words)
        {
            if (!wordCount.ContainsKey(word))
                wordCount[word] = 0;
            wordCount[word]++;
            isSubSequenceConfirmedEarlier[word] = false;
        }

        foreach (var word in wordCount.Keys)
        {
            if(isSubSequenceConfirmedEarlier[word]==true)
                count += wordCount[word];
            if (IsSubSequence(s, word))
            {
                isSubSequenceConfirmedEarlier[word] = true;
                count += wordCount[word];
            }
        }

        return count;
    }

    private bool IsSubSequence(string srt, string word)
    {
        int i = 0, j = 0;
        while (i < srt.Length && j < word.Length)
            if (srt[i++] == word[j])
                j++;
        return j == word.Length;
    }
}