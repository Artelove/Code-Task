public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string[] words = new string[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
        string pattern = "abb";
        solution.FindAndReplacePattern(words, pattern);
    }
    string getPatternModel(string word)
    {
        char keyChar = 'a';
        string patternModel = "";
        Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
        foreach (char c in word) { 
            if (keyValuePairs.ContainsKey(c))
                patternModel += keyValuePairs[c];
            else
            {
                keyValuePairs.Add(c, keyChar++);
                patternModel += keyValuePairs[c];
            }
        }
        return patternModel;
    }
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        IList<string> result = new List<string>();
        string patternModel = getPatternModel(pattern);
        foreach (var word in words)
        {
            if (patternModel == getPatternModel(word))
                result.Add(word);
        }
        return result;
    }
}