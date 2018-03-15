using System.Collections.Generic;

namespace ConsoleApp
{
    public class LinkedList
    {
        public char Character;

        public LinkedList Next;

        public LinkedList InitiateLinkedList(string str)
        {
            LinkedList linkedListHead;
            LinkedList linkedList = new LinkedList();

            linkedListHead = linkedList;

            foreach (char character in str)
            {
                linkedList.Next = new LinkedList() { Character = character };
                linkedList = linkedList.Next;
            }

            return linkedListHead.Next ?? linkedListHead;
        }

        public LinkedList ReverseLinkedList(LinkedList theLinkedList)
        {
            LinkedList next, previous = null;

            while (theLinkedList != null)
            {
                next = theLinkedList.Next;
                theLinkedList.Next = previous;
                previous = theLinkedList;
                theLinkedList = next;
            }

            return previous;
        }

        public string LinkedListToString(LinkedList theLinkedList)
        {
            string str = string.Empty;

            while (theLinkedList.Next != null)
            {
                str += theLinkedList.Character;
                theLinkedList = theLinkedList.Next;
            }

            str += theLinkedList.Character;

            return str;
        }

        public LinkedList ReverseConstantNoOfElements(LinkedList theLinkedList, int k)
        {
            LinkedList next, current = theLinkedList, previous = null;
            int count = 0;
            Queue<LinkedList> FirstElement = new Queue<LinkedList>();

            while (current != null)
            {
                if (count % k == 0)
                {
                    FirstElement.Enqueue(current);
                }
                count++;
                if (count <= k)
                {
                    theLinkedList = current;
                }
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
                if (count % k == 0 && count / k > 1)
                {
                    FirstElement.Dequeue().Next = previous;
                }
            }
            if (FirstElement.Count == 2)
            {
                FirstElement.Dequeue().Next = previous;
            }
            if (FirstElement.Count == 1)
            {
                FirstElement.Dequeue().Next = null;
            }

            return theLinkedList;
        }
    }
}
