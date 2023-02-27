/*
 * Given an integer array nums, find the  subarray  with the largest sum, and return its sum.
 */

public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum= nums[0];
        int currentSum = nums[0];
        for(int i = 1; i < nums.Length; i++){
            currentSum = Math.Max(nums[i], nums[i] + currentSum);
            sum = Math.Max(currentSum, sum);
        }
        return sum;
    }
}