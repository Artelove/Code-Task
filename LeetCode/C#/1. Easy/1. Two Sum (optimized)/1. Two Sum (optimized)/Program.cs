public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = { 0, 0, 2, 7 };
        int target = 9;
        Console.WriteLine(solution.TwoSum(nums, target)[0] + " " + solution.TwoSum(nums, target)[1]);
    }
    public int[] TwoSum(int[] nums, int target)
    {
        int max = -1;
        int min = 1;
        int variance = 0;
        bool isTargetPositive = target >= 0 ? true : false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (isTargetPositive)
            {
                if (nums[i] <= variance)
                    continue;
            }
            else
                if (nums[i] >= variance)
                continue;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;
                if (variance == 0)
                {
                    if (isTargetPositive)
                        if (nums[i] + nums[j] > max) max = nums[i] + nums[j];
                        else
                        if (nums[i] + nums[j] < min) min = nums[i] + nums[j];
                }
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };

            }
            if (max < target)
            {
                variance = target - max;
            }
            if (min > target)
            {
                variance = -min - target;
            }
        }
        return new int[] { 0 };
    }
}