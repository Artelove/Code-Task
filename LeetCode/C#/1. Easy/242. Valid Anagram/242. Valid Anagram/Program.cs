public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string s = "a";
        string t = "ab";
        Console.WriteLine(solution.IsAnagram(s,t));
    }
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false; 
        bool canCountinue;
        List<char> listS = s.ToList();
        List<char> listT = t.ToList();
        while (listS.Count > 0)
        {
            foreach (char sChar in listS)
            {
                canCountinue = false;
                foreach (char tChar in listT)
                {
                    if (sChar == tChar)
                    {
                        listS.Remove(sChar);
                        listT.Remove(tChar);
                        canCountinue = true;
                        break;
                    }
                }
                if (canCountinue) 
                    break;
                else 
                    return false;
            }
        }
        return true;
    }
}