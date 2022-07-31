public class NumArray
{
    private int[] _nums;
    private int _allArraySum = 0;
    static void Main()
    {
        
    }
    public NumArray(int[] nums)
    {
        _nums = nums;
        for (int i = 0; i < _nums.Length; i++)
        {
            _allArraySum += _nums[i];
        }
    }

    public void Update(int index, int val)
    {
        _allArraySum -= _nums[index];
        _allArraySum += val;
        _nums[index] = val;
    }

    public int SumRange(int left, int right)
    {
        int sum = _allArraySum;
        for (int i = 0; i < left; i++)
        {
            sum -= _nums[i];
        }
        for (int i = right + 1; i < _nums.Length; i++)
        {
            sum -= _nums[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */