public class Solution {
    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = new[] {2,15,3,7,8,6,18};
        Console.WriteLine(solution.LengthOfLIS(nums));
    }

    public int LengthOfLIS(int[] nums) 
    {
        if(nums == null || nums.Count() == 0)
            return 0;
        var dp = new List<int>();
        foreach(var num in nums)
        {
            if(!dp.Any() || dp[^1] < num)
            {
                dp.Add(num);
            }
            else
            {
                var index = dp.BinarySearch(num);
                if(index < 0)
                {
                    index = ~index;
                }
                dp[index] = num;
            }
        }
        return dp.Count();
    }
}