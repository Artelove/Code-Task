public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = new int[] { 1,3,5,6};
        int target = 2;
        Console.WriteLine(solution.SearchInsert(nums, target));
    }
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target) 
                return i;
        }
        return nums.Length;
    }
}