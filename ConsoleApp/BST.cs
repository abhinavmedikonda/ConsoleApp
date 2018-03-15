using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class BST
    {
        public BST Left;
        public BST Right;
        public int Current;

        public int TotalPossibleBSTs(int n)
        {
            int[] possibility = new int[n + 1];

            if (n > 0)
            {
                possibility[0] = 1;
            }
            else
            {
                return 0;
            }
            if (n > 1)
            {
                possibility[1] = 1;
            }

            for (int m = 2; m < n + 1; m++)
            {
                for (int p = 0; p < m; p++)
                {
                    possibility[m] += possibility[p] * possibility[m - p - 1];
                }
            }

            return possibility[n];
        }
    }
}
