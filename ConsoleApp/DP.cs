using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class DP
    {
        public class Item
        {
            public string Name;
            public int Weight;
            public int Value;
        }

        public int Knapsack(List<Item> theItems, int theWeight)
        {
            int[,] matrix = new int[theItems.Count, theWeight];

            for (int i = 0; i < theItems.Count; i++)
            {
                for (int j = 0; j < theWeight; j++)
                {
                    if (theItems[i].Weight <= j + 1)
                    {
                        int bestOfRestWeight = (j + 1 - theItems[i].Weight == 0 || i == 0) ? 0 : matrix[i - 1, j - theItems[i].Weight];
                        int withCurrentItem = theItems[i].Value + bestOfRestWeight;
                        int withoutCurrentItem = i == 0 ? 0 : matrix[i - 1, j];

                        matrix[i, j] = withCurrentItem > withoutCurrentItem ? withCurrentItem : withoutCurrentItem;
                    }
                    else
                    {
                        matrix[i, j] = i == 0 ? 0 : matrix[i - 1, j];
                    }
                }
            }

            return matrix[theItems.Count - 1, theWeight - 1];
        }
    }
}
