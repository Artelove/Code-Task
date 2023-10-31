Solution solution = new Solution();
Console.WriteLine(solution.ClimbStairs(5));

public class Solution
{
    public int ClimbStairs(int n)
    {
        return DoStep(n, 0);
    }

    public int DoStep(int n, int current)
    {
        int result = 0;
        if (current + 1 <= n)
        {
            result+=DoStep(n, current + 1);
        }
        if (current + 2 <= n)
        {
            result += DoStep(n, current + 2);
        }
        if (current == n)
            result++;
        return result;
    }
}