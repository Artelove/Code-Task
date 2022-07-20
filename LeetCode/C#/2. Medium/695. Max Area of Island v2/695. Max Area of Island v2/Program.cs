using System;
class Program
{
    private int gridWidht;
    private int gridHeight;
    static void Main()
    {
        Program program = new Program();
        int[,] grid = {
            {1}
            };
        Console.WriteLine(program.MaxAreaOfIsland(grid));
    }

    private int SearchNearbyCells(int[,] grid, int i, int j)
    {
        if (i < 0 || i > gridHeight || j < 0 || j > gridWidht || grid[i, j] == 0)
            return 0;

        return 1 + SearchNearbyCells(grid,i + 1,j) + SearchNearbyCells(grid,i - 1,j) 
            + SearchNearbyCells(grid,i, j+1) + SearchNearbyCells(grid,i, j-1);
    }

    public int MaxAreaOfIsland(int[,] grid)
    {
        gridHeight = grid.GetLength(0) - 1;
        gridWidht = grid.GetLength(1) - 1;
        int maxCountOfIslandCells = 0;
        for (int i = 0; i <= gridHeight; i++)
            for (int j = 0; j <= gridWidht; j++)
            {
                if (grid[i, j] == 1)
                {
                    int a = SearchNearbyCells(grid,i, j);
                    if (maxCountOfIslandCells < a)
                        maxCountOfIslandCells = a;
                }
            }
        return maxCountOfIslandCells;
    }
}
