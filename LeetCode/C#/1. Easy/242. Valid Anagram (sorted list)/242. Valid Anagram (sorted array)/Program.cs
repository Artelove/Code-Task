public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string s = "anagram";
        string t = "nagaram";
        Console.WriteLine(solution.IsAnagram(s,t));
    }
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        List<char> listS = s.ToList();
        List<char> listT = t.ToList();
        listS.Sort();
        listT.Sort();
        if (listS.SequenceEqual(listT)) 
            return true;
        return false;
    }
}