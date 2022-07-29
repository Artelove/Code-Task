public class Solution
{
    
    static void Main()
    {
        Solution solution = new Solution();
        string[] words = new string[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
        string pattern = "abb";
        solution.FindAndReplacePattern(words, pattern);
    }
    private string GetPatternModel(string word)
    {
        char keyChar = 'a';
        string patternModel = "";
        Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
        foreach (char c in word)
        {
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
    private bool CheckForSamePatternByOneChar(string word, string pattern)
    { 
        Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
        char keyChar = 'a';
        char patternCharModel;
        for (int i = 0; i < word.Length; i++)
        {
            if (keyValuePairs.ContainsKey(word[i]))
                patternCharModel = keyValuePairs[word[i]];
            else
            {
                keyValuePairs.Add(word[i], keyChar++);
                patternCharModel = keyValuePairs[word[i]];
            }
            if (patternCharModel != pattern[i]) 
                return false;
        }
        return true;
    }
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {

        IList<string> result = new List<string>();
        string patternModel = GetPatternModel(pattern);
        foreach (var word in words)
        {
            if (word.Length != pattern.Length) continue;
            if (CheckForSamePatternByOneChar(word, patternModel))
                result.Add(word);
        }
        /*foreach (var item in result)
        {
            Console.WriteLine(item);
        }*/
        return result;
    }
}