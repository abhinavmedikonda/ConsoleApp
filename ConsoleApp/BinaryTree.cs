using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class BinaryTree
    {
        public int Current { get; set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        public BinaryTree LowestCommenAncestor(BinaryTree root, BinaryTree node1, BinaryTree node2)
        {
            if (node1 == null && node2 == null)
            {
                return null;
            }
            if (node1 == null)
            {
                return node2;
            }
            if (node2 == null)
            {
                return node1;
            }

            return ContainsNode(root, node1, node2);
        }

        private BinaryTree ContainsNode(BinaryTree currentNode, BinaryTree node1, BinaryTree node2)
        {
            if (currentNode == null)
            {
                return null;
            }

            BinaryTree containsInLeft = ContainsNode(currentNode.Left, node1, node2);
            BinaryTree containsInRight = ContainsNode(currentNode.Right, node1, node2);

            if (containsInLeft != null && containsInRight != null)
            {
                return currentNode;
            }
            if (currentNode == node1)
            {
                return node1;
            }
            if (currentNode == node2)
            {
                return node2;
            }
            if (containsInLeft != null)
            {
                return containsInLeft;
            }
            if (containsInRight != null)
            {
                return containsInRight;
            }

            return null;
        }
    }
}
