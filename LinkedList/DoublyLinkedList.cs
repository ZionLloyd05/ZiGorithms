using System;

namespace algorithm_v2.LinkedList
{
    public class DoublyLinkedList
    {
        internal DNode head;
    }

    public class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;

        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }

    public class HelperDLL
    {
        public void InsertFront(DoublyLinkedList doubly, int data)
        {
            DNode newNode = new DNode(data);
            DNode temp = doubly.head;

            if (temp == null)
            {
                doubly.head = newNode;
                return;
            }

            newNode.next = temp;
            newNode.prev = null;
            temp.prev = newNode;
            doubly.head = newNode;
        }

        public void InsertAfter(DoublyLinkedList doubly, int prevItem, int newItem)
        {
            DNode prevNode = FindNode(doubly, prevItem);
            if (prevNode == null)
            {
                Exception e = new Exception("Prev item cannot be null");
                throw e;
            }

            DNode newNode = new DNode(newItem)
            {
                next = prevNode.next,
                prev = prevNode
            };
            if (newNode.next != null)
                newNode.next.prev = newNode;
            prevNode.next = newNode;
        }

        public void InsertBefore(DoublyLinkedList doubly, int itemBefore, int newItem)
        {
            DNode nodeBefore = FindNode(doubly, itemBefore);
            if (nodeBefore == null) throw new Exception("Item before cannot be null");

            DNode newNode = new DNode(newItem)
            {
                next = nodeBefore,
                prev = nodeBefore.prev
            };

            nodeBefore.prev.next = newNode;
            nodeBefore.prev = newNode;
        }

        public void InsertLast(DoublyLinkedList doubly, int newItem)
        {
            int lastItem = GetLastItem(doubly);
            if (lastItem == 0) throw new Exception("Link is empty");
            InsertAfter(doubly, lastItem, newItem);
        }

        public int GetLastItem(DoublyLinkedList doubly)
        {
            DNode temp = doubly.head;
            if (temp == null) return 0;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp.data;
        }

        public DNode FindNode(DoublyLinkedList doubly, int item)
        {
            DNode temp = doubly.head;
            while (temp != null && temp.data != item)
            {
                temp = temp.next;
            }

            if (temp == null) return null;

            return temp;
        }

        public void PrintList(DoublyLinkedList doubly)
        {
            DNode temp = doubly.head;

            while (temp != null)
            {
                if (temp.next != null)
                    Console.Write(temp.data + "->");
                else
                    Console.Write(temp.data);
                temp = temp.next;
            }
        }
    }
}