using System;

namespace algorithm_v2.CrackingTheCodeInterview
{
    public class SNode
    {
        internal int data;
        internal SNode next;

        public SNode(int d)
        {
            data = d;
        }
    }

    public class SinglyLinkList
    {
        SNode head;



        public void InsertAtFront(int item)
        {

            SNode head = this.head;

            SNode newNode = new SNode(item)
            {
                next = head
            };

            this.head = newNode;

        }

        public void InsertNext(int item)
        {
            SNode curr = this.head;

            while (curr.next != null && curr.next.data != -1)
            {
                curr = curr.next;
            }

            SNode newNode = new SNode(item);

            newNode.next = curr.next;
            curr.next = newNode;

        }

        public void InsertLast(int item)
        {
            SNode curr = this.head;

            while (curr != null && curr.next != null)
            {
                curr = curr.next;
            }

            SNode newNode = new SNode(item);

            curr.next = newNode;

        }

        private SinglyLinkList ReverseLinkedList(SinglyLinkList singly)
        {
            log("Reversing linked list", true);
            SNode curr = singly.head, prev = null, next = null;

            while (curr.data != -1)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            singly.head = prev;

            return singly;

        }

        public SNode ReverseGroupedLinkedList(SinglyLinkList singly, int m, int n)
        {
            SNode ll_head = singly.head, temp = singly.head, dummy_node = null, prev = null;

            SNode curr = null, rprev = null, rtemp = null;

            int count = 1;

            log("Real List");
            PrintLinkList(singly);
            log("");

            while (temp != null && count != m)
            {
                prev = temp;
                temp = temp.next;
                count++;
            }

            log("temp ==> ", false);
            log(temp.data.ToString());

            prev.next = dummy_node;
            dummy_node = temp;

            rprev = dummy_node;
            curr = temp;

            while (curr != null && count != n)
            {
                rtemp = curr.next;
                curr.next = rprev;
                rprev = curr;
                curr = rtemp;
            }

            prev.next = rprev;

            ll_head = prev;

            return ll_head;
        }


        public SNode AddTwoLinkedList(SinglyLinkList singly_first, SinglyLinkList singly_second)
        {
            log("Adding Linked List", true);

            SNode first, second, res = null, prev = null, temp = null;
            int carry = 0, sum;

            first = singly_first.head;
            second = singly_second.head;

            while (first != null || second != null)
            {
                int num_first = 0, num_second = 0;

                if (first != null) num_first = first.data;
                if (second != null) num_second = second.data;

                sum = carry + num_first + num_second;

                if (sum >= 10) carry = 1;
                else carry = 0;

                sum = sum % 10;

                temp = new SNode(sum);

                if (res == null)
                {
                    res = temp;
                }
                else
                {
                    prev.next = temp;
                }

                prev = temp;

                if (first != null) first = first.next;
                if (second != null) second = second.next;

            }

            if (carry > 0) temp.next = new SNode(carry);

            PrintNode(res);
            return res;
        }

        public void PrintNode(SNode node)
        {
            log("Printing Node - Sum result", true);
            while (node != null)
            {
                if (node.next == null)
                    log(node.data.ToString(), false);
                else
                    log(node.data.ToString() + "->", false);

                node = node.next;
            }
            log("", true);
            log("==================", true);
        }

        public void log(string message, bool isNewLine = true)
        {
            if (isNewLine) Console.WriteLine(message);
            else Console.Write(message);
        }

        public void PrintLinkList(SinglyLinkList singly)
        {
            log("printing linked list", true);
            SNode temp = singly.head;

            while (temp != null)
            {
                if (temp.next == null)
                    log(temp.data.ToString(), false);
                else
                    log(temp.data.ToString() + "-> ", false);

                temp = temp.next;
            }
            log("", true);
            log("==================", true);
        }

        public void PrintLL()
        {

            SNode temp = this.head;

            while (temp != null)
            {
                if (temp.next == null)
                    Console.Write(temp.data);
                else
                    Console.Write(temp.data + "-> ");

                temp = temp.next;
            }
        }
    }
}