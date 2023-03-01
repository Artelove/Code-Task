public int MaxProfit(int[] prices) {
         int min = prices[0];
        int profit = 0;
        foreach (int curr in prices) 
        {
            profit = Math.Max(profit, curr-min);
            min = Math.Min(min, curr);
        }
        return profit;
    }