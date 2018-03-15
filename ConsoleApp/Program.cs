using System;

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

            BST bst = new BST();
            Console.Write(bst.TotalPossibleBSTs(6));
            Console.Read();
        }
    }
}
