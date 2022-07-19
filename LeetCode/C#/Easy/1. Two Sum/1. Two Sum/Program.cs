public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = {0,0,2,7};
        int target = 9;
        Console.WriteLine(solution.TwoSum(nums, target)[0] + " " + solution.TwoSum(nums, target)[1]);
    }
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = 0; j < nums.Length; j++)
                if (i != j && nums[i] + nums[j] == target)
                    return new int[] { i, j };
        return new int[0];
    }
}