using System;
class HelloWorld
{
    private int mLenght;
    private int nLenght;
    private long [,,] cache;
    private int currentMove;
    private int Module = 1000000007;
    static void Main()
    {
        HelloWorld helloWorld = new HelloWorld();
        Console.WriteLine("Hello World");
        Console.WriteLine(helloWorld.FindPaths(45,35, 47, 20, 31));
    }
    public bool IsPositionOutOfBound(int i, int j)
    {
        if (i >= mLenght || i < 0 || j >= nLenght || j < 0)
            return true;
        return false;
    }
    public long Move(int maxMove, int i, int j)
    {
        bool isPos = IsPositionOutOfBound(i, j);
        
        if (isPos)
        {
            if (maxMove == 0)
                return 1;
        }
        else
        if (maxMove >= 1)
        {
            if (cache[i, j, maxMove] > 0)
                return cache[i, j, maxMove];
            cache[i, j, maxMove] = (Move(maxMove - 1, i + 1, j) % Module + Move(maxMove - 1, i - 1, j) % Module +
                Move(maxMove - 1, i, j + 1) % Module + Move(maxMove - 1, i, j - 1) % Module) % Module;
            return cache[i, j, maxMove] % Module;
        }
        return 0;
    }
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        nLenght = n;
        mLenght = m;
        long countOfOutOfBoundary = 0;
        currentMove = 0;
        cache = new long[m, n, maxMove+1];
        for (int i = 1; i <= maxMove; i++)
        {
            long a = Move(i, startRow, startColumn) % Module;
            countOfOutOfBoundary += a;
            countOfOutOfBoundary %= Module;
        }
        int intCount = (int)countOfOutOfBoundary % Module; ;
        return intCount;
    }
}

