public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = new int[] { 3,2,2,3 };
        int val = 3;
        Console.WriteLine(solution.RemoveElement(nums, val));
    }
    public int RemoveElement(int[] nums, int val)
    {
        int notValueIntCount = 0, i;
        for (i = 0, notValueIntCount = 0; i < nums.Length; i++)
        {
            if (nums[i] != val) {
                nums[notValueIntCount] = nums[i];
                notValueIntCount++;
            }
        }
        return notValueIntCount;
    }
}