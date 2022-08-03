public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] digits = new int[] { 9 };
        foreach (int digit in solution.PlusOne(digits))
            Console.Write(digit + " ");
    }
    public int[] PlusOne(int[] digits)
    {
        digits[digits.Length-1] += 1;
        for (int i = digits.Length-1; i >= 0; i--)
        {
            if (digits[i] == 10)
            {
                digits[i] = 0;
                if (i - 1 == -1)
                {
                    int[] newDigit = new int[digits.Length + 1];
                    newDigit[0] = 1;
                    for (int j = 1; j < newDigit.Length; j++)
                        newDigit[j] = digits[i];
                    return newDigit;
                }
                digits[i - 1] += 1;
            }
        }
        return digits;
    }
}