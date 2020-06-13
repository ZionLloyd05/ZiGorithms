using System;

namespace algorithm_v2.CrackingTheCodeInterview
{
    public class LLPartition
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public Node newNode(int data)
        {
            Node new_node = new Node();
            new_node.data = data;
            new_node.next = null;
            return new_node;
        }

        public Node Partition(Node head, int x)
        {
            /* Let us initialize first and last nodes of  
            three linked lists  
            1) Linked list of values smaller than x.  
            2) Linked list of values equal to x.  
            3) Linked list of values greater than x.*/

            Node smallerHead = null, smallerLast = null;
            Node greaterHead = null, greaterLast = null;
            Node equalHead = null, equalLast = null;

            // Now iterate original list and connect nodes  
            // of appropriate linked lists.
            while (head != null)
            {

                // if current node is equal to x, append
                // it to the list of x values
                if (head.data == x)
                {

                    if (equalHead == null)
                        equalHead = equalLast = head;
                    else
                    {
                        equalLast.next = head;
                        equalLast = equalLast.next;
                    }
                }

                // if current node is less to x, append
                // it to the list of x values
                else if (head.data < x)
                {
                    if (smallerHead == null)
                        smallerLast = smallerHead = head;
                    else
                    {
                        smallerLast.next = head;
                        smallerLast = head;
                    }
                }
                // append to the greater
                else
                {
                    if (greaterHead == null)
                        greaterLast = greaterHead = head;
                    else
                    {
                        greaterLast.next = head;
                        greaterLast = greaterLast.next;
                    }
                }

                head = head.next;
            }

            // Fix end of greater ll to null if the list has some nodes
            if (greaterLast != null)
                greaterLast.next = null;

            // connect three lists

            // if smaller list is empty
            if (smallerHead == null)
            {
                if (equalHead == null)
                    return greaterHead;
                equalLast.next = greaterHead;
                return equalHead;
            }

            // if smaller list is not empty
            // and equal list is empty
            if (equalHead == null)
            {
                smallerLast.next = greaterHead;
                return smallerHead;
            }

            // If both smaller and equal list  
            // are non-empty  
            smallerLast.next = equalHead;
            equalLast.next = greaterHead;
            return smallerHead;
        }

        public void printList(Node head)
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}