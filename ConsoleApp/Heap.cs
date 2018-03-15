using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Heap
    {
        public int[] HeapSort(int[] theArray)
        {
            MinHeap(ref theArray);

            int heapEnd = theArray.Length - 1;
            for (int i = theArray.Length - 1; i > 0; i--)
            {
                Swap(ref theArray, 0, i);
                Heapify(ref theArray, 0, i - 1);
            }

            return theArray;
        }

        public void MinHeap(ref int[] theArray)
        {
            //int levelElements = 1, totalElements = 1, heapedIndex = 1;

            //while (true)
            //{
            //    levelElements *= 2;
            //    heapedIndex = totalElements;
            //    totalElements += levelElements;
            //    totalElements = totalElements < theArray.Length ? totalElements : theArray.Length;

            //    for (int i = heapedIndex; i < totalElements; i++)
            //    {
            //        swapTillHeaped(ref theArray, i);
            //    }

            //    if (totalElements == theArray.Length)
            //    {
            //        return theArray;
            //    }
            //}

            for (int i = theArray.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(ref theArray, i, theArray.Length - 1);
            }
        }

        private void Heapify(ref int[] theArray, int theIndex, int heapEnd)
        {
            int leftChildIndex = 2 * theIndex + 1, rightChildIndex = 2 * theIndex + 2;

            if (leftChildIndex > heapEnd)
            {
                return;
            }
            if (theArray[theIndex] > theArray[leftChildIndex])
            {
                Swap(ref theArray, theIndex, leftChildIndex);
                Heapify(ref theArray, leftChildIndex, heapEnd);
            }
            if (rightChildIndex > heapEnd)
            {
                return;
            }
            if (theArray[theIndex] > theArray[rightChildIndex])
            {
                Swap(ref theArray, theIndex, rightChildIndex);
                Heapify(ref theArray, rightChildIndex, heapEnd);
            }
        }

        private void Swap(ref int[] array, int index, int chieldIndex)
        {
            int temp = array[index];
            array[index] = array[chieldIndex];
            array[chieldIndex] = temp;
        }

        private void swapTillHeaped(ref int[] theArray, int index)
        {
            int topIndex = (index - 1) / 2;

            if (theArray[index] < theArray[topIndex])
            {
                int temp = theArray[index];
                theArray[index] = theArray[topIndex];
                theArray[topIndex] = temp;

                if (topIndex == 0)
                {
                    return;
                }
                else
                {
                    swapTillHeaped(ref theArray, topIndex);
                }
            }
        }
    }
}
