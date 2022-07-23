public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = new int[] { 1,1,2,2,3,3,3,3,4,5,6,6,6,6};
        Console.WriteLine(solution.RemoveDuplicates(nums));
    }
    public int RemoveDuplicates(int[] nums)
    {
        int currentDigit = nums[0];
        int duplicatedCount = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > currentDigit)
            {
                currentDigit = nums[i];
                nums[duplicatedCount] = nums[i];
                duplicatedCount++;
            }
        }
        return duplicatedCount;
    }
}