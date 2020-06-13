using System;
using System.Collections;
using System.Collections.Generic;
using algorithm_v2.LinkedList;

namespace algorithm_v2.CrackingTheCodeInterview
{
    public class Exercise
    {
        public void RemoveDups(SinglyLinkedList singly)
        {
            LinkedList.SNode temp = singly.head;
            LinkedList.SNode prev = null;

            Hashtable lht = new Hashtable
            {
                /**
                    Since the first element will never be a duplicate
                    we can therefore add it into the hashtable
                    as an initial element
                */
                { temp.data, 1 }
            };

            while (temp.next != null)
            {
                Console.WriteLine(temp.next.data);
                prev = temp;
                CheckStatusAndPerformOperation(temp.next, lht, prev);
                temp = temp.next;
            }

            HelperSLL objHelper = new HelperSLL();
            objHelper.PrintList(singly);
            Console.WriteLine();
            Console.WriteLine("Done");
        }

        public int KthItemSingly(SinglyLinkedList singly, int kth)
        {
            LinkedList.SNode main_ptr_node = singly.head;
            LinkedList.SNode ref_ptr_node = singly.head;

            int count = 0;
            while (ref_ptr_node != null && kth != count)
            {
                // Console.WriteLine("Count - {0}, Kth - {1}", count, kth);
                // Console.WriteLine("ref - {0} , main - {1}", ref_ptr_node.data, main_ptr_node.data);
                ref_ptr_node = ref_ptr_node.next;
                count++;
            }

            // Console.WriteLine("Broken out of Loop");

            while (ref_ptr_node != null)
            {
                // Console.WriteLine("Count - {0}, Kth - {1}", count, kth);
                // Console.WriteLine("ref - {0} , main - {1}", ref_ptr_node.data, main_ptr_node.data);
                ref_ptr_node = ref_ptr_node.next;
                main_ptr_node = main_ptr_node.next;
            }

            return main_ptr_node.data;
        }

        public void DeleteNodeFromMiddle(SinglyLinkedList singly, int? itemToDelete)
        {
            if (itemToDelete == null) return;
            LinkedList.SNode temp = singly.head;
            LinkedList.SNode prev = null;

            while (temp.data != -1 && temp.data != itemToDelete)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp.data != -1)
            {
                prev.next = temp.next;
            }

            return;
        }


        /**
            //============ Helper Functions ========================
         */

        private void CheckStatusAndPerformOperation(
            LinkedList.SNode curr,
            Hashtable lht,
            LinkedList.SNode prev = null
            )
        {
            if (curr == null)
            {
                return;
            }

            Console.WriteLine("checking status for {0}", curr.data);

            int data = curr.data;
            int len = 0;

            if (lht[data] != null)
            {
                len = (int)lht[data];
            }

            if (len == 0)
            {
                Console.WriteLine("lenght is  0");
                lht.Add(data, 1);
                //this.LogHash(lht);
            }
            else if (len == 1)
            {
                Console.WriteLine("lenght is  1");
                RemoveNode(curr, lht, prev);
            }
        }

        private void RemoveNode(LinkedList.SNode curr, Hashtable lht, LinkedList.SNode prev = null)
        {
            if (curr == null)
            {
                return;
            }
            Console.WriteLine("removing {0}", curr.data);
            Console.WriteLine("");

            //lht[curr.data] = (int)lht[curr.data] - 1;
            prev.next = curr.next;
            CheckStatusAndPerformOperation(curr.next, lht, prev);
        }

        private void LogHash(Hashtable lht)
        {
            Console.WriteLine();
            Console.WriteLine("================Logging HashTable========================");
            foreach (var key in lht.Keys)
            {
                Console.WriteLine("Key {0} -> Value {1}", key, lht[key]);
            }
            Console.WriteLine("================Logging HashTable========================");
            Console.WriteLine();
        }

        private void log(string message, int data)
        {
            Console.WriteLine(message);
        }

        private int LinkedListSize(SinglyLinkedList singly, List<KeyValuePair<int, int>> lht)
        {
            LinkedList.SNode temp = singly.head;

            int count = 0;
            while (temp != null)
            {
                count++;
                this.AddToList(lht, temp.data, count);
                temp = temp.next;

                this.PrintList(lht);
            }

            return count;
        }



        private void PrintList(List<KeyValuePair<int, int>> lht)
        {
            Console.WriteLine();
            Console.WriteLine("================Logging List========================");
            for (int i = 0; i < lht.Count; i++)
            {
                Console.WriteLine("Key {0} - Value {1}", lht[i].Key, lht[i].Value);
            }
            Console.WriteLine("================Logging List========================");
            Console.WriteLine();
        }

        private void AddToList(List<KeyValuePair<int, int>> lht, int key, int value)
        {
            var element = new KeyValuePair<int, int>(key, value);
            lht.Add(element);
        }

    }

}