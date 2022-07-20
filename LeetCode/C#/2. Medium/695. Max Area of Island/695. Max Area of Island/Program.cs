using System;
class Program
{
    private List<int[]> checkedGridCells = new List<int[]>();
    private List<int> islandsArea = new List<int>();
    private int gridWidht;
    private int gridHeight;
    private int [,] grid;
    int[] right = new int[] { 0, 1 };
    int[] left = new int[] { 0, -1 };
    int[] up = new int[] { 1, 0 };
    int[] down = new int[] { -1, 0 };
    static void Main()
    {
        Program program = new Program();
        int[,] grid = {
            {1}
            };
        Console.WriteLine(program.MaxAreaOfIsland(grid));
        //return program.MaxAreaOfIsland(grid);


    }

    private bool IsCellUsed(int[] cell)
    {
        foreach (var _cell in checkedGridCells)
        {
            if (_cell[0] == cell[0] && _cell[1] == cell[1])
                return true;
        }
        return false;

    }

    private void AddCellToUsed(int [] cell) => checkedGridCells.Add(cell);

    private bool CheckPossibleToGetCell(int[] cellIndex)
    {
        if (cellIndex[0] < 0 || cellIndex[0] > gridHeight || cellIndex[1] < 0 || cellIndex[1] > gridWidht)
            return false;
        return true;
    }
    private int[] SumVectors(int[] a, int[] b) {
        return new int[] { a[0] + b[0], a[1] + b[1] };
    }
    private int SearchNearbyCells(int [] cell)
    {
        int currentFoundedCells = 0;
        if (grid[cell[0], cell[1]] == 1 && !IsCellUsed(cell))
        {
            AddCellToUsed(cell);
            currentFoundedCells++;
            int[] rightCell = SumVectors(cell, right);
            int[] leftCell = SumVectors(cell, left);
            int[] upCell = SumVectors(cell, up);
            int[] downCell = SumVectors(cell, down);
            if (CheckPossibleToGetCell(rightCell))
                currentFoundedCells += SearchNearbyCells(rightCell);
            if (CheckPossibleToGetCell(leftCell))
                currentFoundedCells += SearchNearbyCells(leftCell);
            if (CheckPossibleToGetCell(upCell))
                currentFoundedCells += SearchNearbyCells(upCell);
            if (CheckPossibleToGetCell(downCell))
                currentFoundedCells += SearchNearbyCells(downCell);
        }
        return currentFoundedCells;
    }

    public int MaxAreaOfIsland(int[,] grid)
    {
        this.grid = grid;
        gridHeight = grid.GetLength(0)-1;
        gridWidht = grid.GetLength(1)-1;
        int maxCountOfIslandCells = 0;
        for (int i = 0; i <= gridHeight; i++)
            for (int j = 0; j <= gridWidht; j++)
            {
                if(grid[i,j] == 1) {
                    if (IsCellUsed(new int[] { i, j }))
                    {
                        continue;
                    }
                    else
                    {
                        int a = SearchNearbyCells(new int[] {i,j});
                        if (maxCountOfIslandCells < a)
                            maxCountOfIslandCells = a;
                    }
                }
            }
        return maxCountOfIslandCells;
    }
}
