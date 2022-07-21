public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        string str = "{[]}()";
        Console.WriteLine(solution.IsValid(str));
    }
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var item in s)
        {
            if (stack.Count > 0)
            {
                if (
                    item == ')' && stack.Peek() == '(' ||
                    item == ']' && stack.Peek() == '[' ||
                    item == '}' && stack.Peek() == '{'
                )
                    stack.Pop();
                else
                    stack.Push(item);
            }
            else
                stack.Push(item);
        }

        if (stack.Count == 0)
            return true;
        else
            return false;
    }
}