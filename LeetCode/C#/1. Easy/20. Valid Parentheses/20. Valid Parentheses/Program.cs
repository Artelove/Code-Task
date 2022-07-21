public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string str = "()[[]][]";
        Console.WriteLine(solution.IsValid(str));
    }
    public bool IsValid(string s)
    {
        List<char> needToClose = new List<char>();
        foreach (char currentChar in s)
        {
            if ('(' == currentChar)
                needToClose.Add(currentChar);
            else
            if ('{' == currentChar) needToClose.Add(currentChar);
            else
            if ('[' == currentChar) needToClose.Add(currentChar);
            else
            if (needToClose.Count > 0)
            {
                int arrCount = needToClose.Count - 1;
                char needToCloseChar = needToClose[arrCount];
                if ((')' == currentChar && '(' == needToCloseChar) ||
                    ('}' == currentChar && '{' == needToCloseChar) ||
                    (']' == currentChar && '[' == needToCloseChar))
                        needToClose.RemoveAt(arrCount);
                else
                    return false;
            }
            else return false;
        }
        if (needToClose.Count == 0)
            return true;
        else
            return false;

    }
}