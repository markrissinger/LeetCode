using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode75.CanPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int flowerbedLength = flowerbed.Length;

            if (n == 0)
                return true;

            if ((n > 1) && (n > (flowerbedLength / 2) + 1))
                return false;

            for (int i = 0; i < flowerbedLength; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (i == 0)
                    {
                        if (i + 1 < flowerbedLength && flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                        else if (i + 1 == flowerbedLength && flowerbed[i] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                    else if (i == flowerbedLength - 1)
                    {
                        if (i - 1 >= 0 && flowerbed[i - 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                    else
                    {
                        if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }

                    if (n == 0)
                    {
                        break;
                    }
                }
            }

            return n == 0;
        }
    }
}
