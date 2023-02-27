/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
*/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionaryint,int dict = new Dictionaryint,int();
        for(int i = 0; i  nums.Length; i++){
            if(dict.TryAdd(nums[i],1) == false)
                return true;
        }
        return false;
    }
}
