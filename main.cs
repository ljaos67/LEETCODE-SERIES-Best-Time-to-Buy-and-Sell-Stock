public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int pIST = 0;
        int best = 0;
        int buyingPrice = prices[0];
        for(int i = 0; i < prices.Count(); i++)
        {
            if(prices[i] - buyingPrice > best)
            {
                best = prices[i] - buyingPrice;
            }
            else
            {
                if(prices[i] < buyingPrice)
                {
                    buyingPrice = prices[i];
                }
            }
        }
        return (best > 0 ? best : 0);
    }
}
