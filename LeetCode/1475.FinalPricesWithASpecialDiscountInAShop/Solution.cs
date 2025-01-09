using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1475.FinalPricesWithASpecialDiscountInAShop
{
    public class Solution
    {
        public int[] FinalPrices(int[] prices)
        {
            int pricesLength = prices.Length;

            int[] discountPrices = new int[prices.Length];
            prices.CopyTo(discountPrices, 0);

            for (int i = 0; i < pricesLength - 1; i++)
            {
                for (int j = i + 1; j < pricesLength; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        discountPrices[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }

            discountPrices[pricesLength - 1] = prices[pricesLength - 1];
            return discountPrices;
        }
    }
}
