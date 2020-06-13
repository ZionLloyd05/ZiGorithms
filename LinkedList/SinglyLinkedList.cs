using System;

namespace algorithm_v2.LinkedList
{
    public class SinglyLinkedList
    {
        internal SNode head;

    }

    internal class SNode
    {
        internal int data;
        internal SNode next;

        public SNode(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class HelperSLL
    {
        internal void InsertAfter(SinglyLinkedList singlyLinked, int prev_item, int new_data)
        {
            SNode prevNode = FindNode(singlyLinked, prev_item);

            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }

            SNode newNode = new SNode(new_data)
            {
                next = prevNode.next
            };

            prevNode.next = newNode;
        }

        internal void InsertFront(SinglyLinkedList singlyList, int new_data)
        {
            SNode newNode = new SNode(new_data)
            {
                next = singlyList.head
            };

            singlyList.head = newNode;
        }

        internal void InsertLast(SinglyLinkedList singly, int new_data)
        {
            SNode newNode = new SNode(new_data);
            if (singly.head == null)
            {
                singly.head = newNode;
                return;
            }
            SNode lastNode = GetLastNode(singly);
            lastNode.next = newNode;
        }

        internal void DeleteNodeByKey(SinglyLinkedList singly, int key)
        {
            SNode prev = null;
            SNode temp = singly.head;

            if (temp != null && temp.data == key)
            {
                singly.head = temp.next;
                return;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            prev.next = temp.next;
        }

        internal void DeleteNodeByPosition(SinglyLinkedList singly, int position)
        {
            if (singly.head == null) return;

            SNode temp = singly.head;

            if (position == 0)
            {
                singly.head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < position; i++)
            {
                temp = temp.next;
            }

            if (temp == null || temp.next == null) return;

            SNode nextNode = temp.next.next;

            temp.next = nextNode;
        }

        internal void ReverseLinkedList(SinglyLinkedList singly)
        {
            if (singly.head == null) return;

            SNode prev = null;
            SNode current = singly.head;
            SNode temp = null;

            while (current != null)
            {
                Console.WriteLine();
                temp = current.next;
                if (temp != null)
                    Console.WriteLine("temp -> {0}", temp.data);
                current.next = prev;
                if (current.next != null)
                    Console.WriteLine("current.next -> {0}", current.next.data);
                prev = current;
                if (prev != null)
                    Console.WriteLine("prev -> {0}", prev.data);
                current = temp;
                if (current != null)
                    Console.WriteLine("current -> {0}", current.data);
            }

            singly.head = prev;
        }

        internal void FindMiddle(SinglyLinkedList singly)
        {
            SNode fast_ptr = singly.head;
            SNode slow_ptr = singly.head;

            if (singly.head != null)
            {

                while (fast_ptr != null && fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("The middle element is {0}", slow_ptr.data);
            }
        }

        /*This function prints contents of linked list starting from the head */
        public void PrintList(SinglyLinkedList singlyList)
        {
            SNode nodeHead = singlyList.head;

            while (nodeHead != null)
            {
                Console.Write(nodeHead.data + " -> ");
                nodeHead = nodeHead.next;
            }
        }

        private SNode GetLastNode(SinglyLinkedList singlyLinkedList)
        {
            SNode temp = singlyLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            // Console.WriteLine(temp.data);
            return temp;
        }

        private SNode FindNode(SinglyLinkedList singlyLinkedList, int item)
        {
            SNode head = singlyLinkedList.head;

            while (head != null && head.data != item)
            {
                head = head.next;
            }

            if (head != null && head.data == item)
            {
                return head;
            }
            else
            {
                return null;
            }
        }
    }
}