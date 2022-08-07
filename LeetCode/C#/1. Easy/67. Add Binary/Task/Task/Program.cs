public class Solution {
    static void Main()
    {
        Solution solution = new Solution();
        String a = "100";
        String b = "110010";
        Console.WriteLine(solution.AddBinary(a, b));
    }

    private int[] StringToDigitArray(string number)
    {
        List<int> digits = new List<int>();
        foreach (var ch in number)
        {
            digits.Add(Int32.Parse(ch.ToString()));
        }
        return digits.ToArray();
    }
    public string AddBinary(string a, string b)
    {
        string result = string.Empty;
        int[] a_arr = StringToDigitArray(a);
        int[] b_arr = StringToDigitArray(b);
        Array.Reverse(a_arr);
        Array.Reverse(b_arr);
        int[] longestArray = a_arr.Length > b_arr.Length? a_arr : b_arr;
        int lastSumIndex = Math.Min(a_arr.Length, b_arr.Length);
        int counter = 0;
        int additionalDigit = 0;
        while (lastSumIndex > counter)
        {
            int add = a_arr[counter] + b_arr[counter] + additionalDigit;
            additionalDigit = add / 2;
            add %= 2;
            result += add.ToString();
            counter++;
        }
        for (int i = lastSumIndex; i < longestArray.Length; i++)
        {
            int add = longestArray[i] + additionalDigit;
            additionalDigit = add / 2;
            add %= 2;
            result += add.ToString();
        }

        if (additionalDigit != 0) 
            result += additionalDigit.ToString();
        return new string(result.ToCharArray().Reverse().ToArray());
    }
}