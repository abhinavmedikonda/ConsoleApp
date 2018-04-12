using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Cache
    {
        string[] mvItem = new string[100];
        int[] mvFrequency = new int[100];
        Dictionary<string, int> itemsIndex = new Dictionary<string, int>();

        public void VisitItem(string theitem)
        {
            if (itemsIndex.ContainsKey(theitem))
            {
                itemsIndex.TryGetValue(theitem, out int index);
                mvFrequency[index] = mvFrequency[index] + 1;
                CheckIfProgressed(index);
            }
            else
            {
                if (itemsIndex.Count < 100)
                {
                    mvFrequency[itemsIndex.Count] = 1;
                    mvItem[itemsIndex.Count] = theitem;
                    itemsIndex.Add(theitem, itemsIndex.Count);
                }
                else
                {
                    mvFrequency[itemsIndex.Count - 1] = 1;
                    mvItem[itemsIndex.Count - 1] = theitem;
                    itemsIndex.Add(theitem, itemsIndex.Count - 1);
                }
            }
        }

        private void CheckIfProgressed(int index)
        {
            if (index > 0 && mvFrequency[index] >= mvFrequency[index - 1])
            {
                int frequency = mvFrequency[index];
                string item = mvItem[index];
                mvFrequency[index] = mvFrequency[index - 1];
                mvItem[index] = mvItem[index - 1];
                mvFrequency[index - 1] = frequency;
                mvItem[index - 1] = item;
                itemsIndex[mvItem[index]] = index;
                itemsIndex[mvItem[index - 1]] = index - 1;
                CheckIfProgressed(index - 1);
            }
        }
    }
}
