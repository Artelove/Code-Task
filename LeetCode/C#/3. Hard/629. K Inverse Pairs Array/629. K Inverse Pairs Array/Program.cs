using System;
class Program
{
    private int[] array;
    private int[,] cache;
    static void Main()
    {
        int n = 3;
        int k = 1;
        Program program = new Program();
        Console.WriteLine(program.KInversePairs(n, k));
    }

    public int KInversePairs(int n, int k)
    {
        int[,] dp = new int[n + 1, k + 1];
        int inversePairsСount = 0;
        int MOD = 1000000007;
        dp[0, 0] = 1;

        for (int i = 1; i < n + 1; i++)
        {
            
            for (int j = 0; j < k + 1; j++)
            {
                if (j == 0)
                {
                    dp[i, j] = 1;
                    inversePairsСount = 1;
                }
                else
                {
                    inversePairsСount = (inversePairsСount + dp[i - 1, j]) % MOD;
                    if (j - i >= 0)
                    {
                        inversePairsСount = (inversePairsСount + MOD - dp[i - 1, j - i]) % MOD;
                    }
                    dp[i, j] = inversePairsСount;
                }
            }
        }

        return dp[n, k];
    }
}
