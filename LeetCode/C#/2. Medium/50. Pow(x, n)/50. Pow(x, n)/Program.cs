public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        double x = 2;
        int n = 10;
        Console.WriteLine(solution.MyPow(x, n));
    }
    public double MyPow(double x, int n)
    {
        if (n == -1) return 1 / x;
        if (n == 0) return 1;
        if (n == 1) return x;

        bool sing = n > 0 ? true : false;
        if (!sing)
            n = -n + 2;
        if (n < 0)
        {
            if (x == 1) return x;
            if (x == 0) return x;
            if (x == -1) return -x;
            return 0;
        }
        if (x == 1 || x == 0 || x == -1) return x;

        double degree = x;
        
        int i = 1;
        if (!sing)
            i = 2;
        // accuracy > 10e-97
        if (x > 0 && x < 0.8 && n > 999) return 0;

        // a crutch on a crutch ....... ^

        int nSqr = 2;
        int nSqrConst = 2;
        bool fastDegree = true;
        while (i < n)
        {
            // acceleration of calculations at large degrees
            if (n >= 4)
            {
                if (nSqr < n)
                {
                    if (sing)
                        x *= x;
                    else
                        x /= x;

                    nSqr *= nSqrConst;
                    continue;
                }
                else
                {
                    if (fastDegree && sing)
                    {

                        n -= nSqr / nSqrConst - 1;
                        fastDegree = false;
                    }
                }
            }

            if (sing)
                x *= degree;
            else
                x /= degree;
            i++;
        }
        return x;
    }
}