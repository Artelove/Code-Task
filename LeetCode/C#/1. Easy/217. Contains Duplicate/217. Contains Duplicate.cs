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