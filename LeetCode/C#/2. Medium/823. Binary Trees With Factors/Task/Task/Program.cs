class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] arr = new[] {2,4,5,10};
        Console.WriteLine(solution.NumFactoredBinaryTrees(arr));
    }
    public int NumFactoredBinaryTrees(int[] arr) {
        Array.Sort(arr);
        Dictionary<int, long> dictionary = new();
        long count = 1;
        int mod = (int)Math.Pow(10, 9) + 7;
        dictionary.Add(arr[0], count);
        
        for(int i = 1; i < arr.Length; i++)
        {
            count = 1;
            
            foreach(var k in dictionary.Keys)
            {
                if(arr[i] % k == 0 && dictionary.ContainsKey(arr[i] / k))
                    count += (dictionary[k] * dictionary[arr[i] / k]);
            }
            dictionary.Add(arr[i], count);
        }
        
        long sum = 0;
        foreach(var v in dictionary.Values)
            sum = (sum + v) % mod;
        
        return (int)sum;
    }
}
