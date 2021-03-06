﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList linkedList = new LinkedList();
            //linkedList = linkedList.InitiateLinkedList(Console.ReadLine());
            //linkedList = linkedList.ReverseConstantNoOfElements(linkedList, 4);
            //Console.WriteLine(linkedList.LinkedListToString(linkedList));
            //Console.Read();

            //Matrix matrix = new Matrix();
            //matrix.SpiralClockwise();

            //Strings strings = new Strings();
            //Console.Write(strings.ReplaceTillShortest(Console.ReadLine()));
            //Console.Read();

            //Arrays arrays = new Arrays();
            //Console.Write(string.Join(",", arrays.MaximumSumSubArray(new int[] { 2, 54, -84, 9, -38, -8, 59, -8 })));
            //Console.Read();

            //Heap heap = new Heap();
            //Console.Write(string.Join(",", heap.HeapSort(new int[] { 2, 54, -84, 9, -38, -8, 59, -8 })));
            //Console.Read();

            //BST bst = new BST();
            //Console.Write(bst.TotalPossibleBSTs(6));
            //Console.Read();

            //BinaryTree binaryTree = new BinaryTree();
            //BinaryTree[] binaryTrees = new BinaryTree[25];
            //for (int i = 0; i < binaryTrees.Length; i++)
            //{
            //    binaryTrees[i] = new BinaryTree();
            //    binaryTrees[i].Current = i + 1;
            //}
            //if (binaryTrees.Length > 0)
            //{
            //    binaryTrees[0].Left = binaryTrees[1];
            //}
            //if (binaryTrees.Length > 1)
            //{
            //    binaryTrees[0].Right = binaryTrees[2];
            //}
            //for (int i = 1; i < binaryTrees.Length / 2; i++)
            //{
            //    binaryTrees[i].Left = binaryTrees[i * 2 + 1];
            //    if (i * 2 + 2 < binaryTrees.Length)
            //    {
            //        binaryTrees[i].Right = binaryTrees[i * 2 + 2];
            //    }
            //}
            //binaryTrees[0] = new BinaryTree { Current = 1, Left = binaryTrees[1], Right = binaryTrees[2] };
            //Console.Write(binaryTree.LowestCommenAncestor(binaryTrees[0], binaryTrees[21], binaryTrees[9])?.Current);
            //Console.Read();

            //Strings strings = new Strings();
            //Console.Write(strings.KMPStringMatch("abcabcabdabcdef", "abcabdabcd"));
            //Console.Read();

            DP dP = new DP();
            List<DP.Item> items = new List<DP.Item> { new DP.Item { Name = "item1", Weight = 4, Value = 8 },
                                                        new DP.Item { Name = "item2", Weight = 6, Value = 5 },
                                                        new DP.Item { Name = "item3", Weight = 3, Value = 7 },
                                                        new DP.Item { Name = "item4", Weight = 9, Value = 4 },
                                                        new DP.Item { Name = "item5", Weight = 2, Value = 6 },
                                                        new DP.Item { Name = "item6", Weight = 7, Value = 2 },
                                                        new DP.Item { Name = "item7", Weight = 3, Value = 9 },
                                                        new DP.Item { Name = "item8", Weight = 5, Value = 3 }};
            Console.Write(dP.Knapsack(items, 25));
            Console.Read();
        }
    }
}
