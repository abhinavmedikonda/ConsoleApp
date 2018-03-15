using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Arrays
    {
        public int[] MaximumSumSubArray(int[] theArray)
        {
            int beginIndex = 0, endIndex = 0, maxSum = 0, lastSum = 0;

            for (int i = 0; i < theArray.Length; i++)
            {
                lastSum += theArray[i];

                if (lastSum > maxSum)
                {
                    maxSum = lastSum;
                    endIndex = i;
                }
                if (lastSum < 0)
                {
                    lastSum = 0;
                    beginIndex = i + 1;
                }
            }

            int[] outArray = new int[endIndex - beginIndex + 1];

            Array.Copy(theArray, beginIndex, outArray, 0, endIndex - beginIndex + 1);
            return outArray;
        }
    }
}
