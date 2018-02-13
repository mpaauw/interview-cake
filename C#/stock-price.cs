public static int stockPrice(int[] prices)
{
    if (prices.Length < 2)
    {
        throw new ArgumentException("Unable to calculate max profit without at least 2 price indexes.", nameof(prices));
    }

    int maxProfit = prices[1] - prices[0];
    int minPrice = prices[0];
    for (int i = 1; i < prices.Length; i++)
    {
        int currentPrice = prices[i];
        int potentialProfit = currentPrice - minPrice;
        maxProfit = Math.Max(maxProfit, potentialProfit);
        minPrice = Math.Min(currentPrice, minPrice);
    }
    return maxProfit;
}