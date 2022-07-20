public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        solution.Generate(30);
    }
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> pascalList = new List<IList<int>>();
        IList<int> previusList = new List<int>();
        IList<int> currentList = new List<int>();
        for (int i = 1; i <= numRows; i++)
        {
            if (i == 1)
            {
                currentList = new List<int>(1);
                currentList.Add(1);
            }
            else
            {
                currentList = new List<int>(i);
                for (int j = 0; j < previusList.Count; j++)
                {
                    if (j == 0)
                    {
                        currentList.Add(1);
                    }
                    else currentList.Add(previusList[j] + previusList[j - 1]);
                }
                currentList.Add(1);
            }
            pascalList.Add(currentList);
            previusList = currentList;
            foreach (var item in currentList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

        }
        return pascalList;
    }
}