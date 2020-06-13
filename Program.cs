using System;
using System.Collections.Generic;
using algorithm_v2.CrackingTheCodeInterview;
using algorithm_v2.Graph;
using algorithm_v2.HackerRank;
using algorithm_v2.LinkedList;
using algorithm_v2.List;
using algorithm_v2.Array;
// using algorithm_v2.LLProblems;
using algorithm_v2.sorting;
using algorithm_v2.Stack;

namespace algorithm_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SinglyLinkedList sll = SingleLinkedListCaller();



            // Practise practise = new Practise ();
            // int[] arr = { 3, 2, 1, 3 };
            // // practise.birthdayCakeCandles (arr);
            // int height = practise.birthdayCakeCandles (arr);
            // Console.WriteLine (height);

            // Graphs graph = new Graphs();
            // int[,] adjMatrix = graph.CreateGraph();
            // graph.TraverseGraph(adjMatrix);
            // graph.ShowNieghbours(1, adjMatrix);

            // Strings str = new Strings ();
            // string result = str.CompressString ("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccccccccccccccccccccccccddee");
            // Console.WriteLine (result);
            // Practise pr = new Practise ();
            // pr.PrintStars (30);

            // SinglyLinkList sl_first = new SinglyLinkList();
            // // sl_first.InsertAtFront(-1);
            // sl_first.InsertAtFront(1);
            // sl_first.InsertNext(2);
            // sl_first.InsertNext(3);
            // sl_first.InsertNext(4);
            // sl_first.InsertLast(5);
            // // sl_first.InsertLast(-1);
            // sl_first.PrintNode(sl_first.ReverseGroupedLinkedList(sl_first, 2, 4));

            Console.WriteLine("");

            // SinglyLinkList sl_last = new SinglyLinkList();
            // // sl_first.InsertAtFront(-1);
            // sl_last.InsertAtFront(7);
            // sl_last.InsertNext(1);
            // sl_last.InsertLast(9);
            // // sl_last.InsertLast(-1);
            // sl_last.PrintLinkList(sl_last);

            // SinglyLinkList sl_helper = new SinglyLinkList();

            // sl_helper.AddTwoLinkedList(sl_first, sl_last);

            // Exercise ex = new Exercise();
            // ex.RemoveDups(sll);

            // int result = ex.KthItemSingly(sll, 4);
            // Console.WriteLine(result);

            // ex.DeleteNodeFromMiddle(sll, 4);
            // HelperSLL objHelper = new HelperSLL();
            // Console.WriteLine();
            // Console.WriteLine("==================");

            // objHelper.PrintList(sll);

            // LLPartition lp = new LLPartition();

            // LLPartition.Node head = lp.newNode(10);
            // head.next = lp.newNode(4);
            // head.next.next = lp.newNode(5);
            // head.next.next.next = lp.newNode(30);
            // head.next.next.next.next = lp.newNode(2);
            // head.next.next.next.next.next = lp.newNode(50);

            // int x = 3;
            // head = lp.Partition(head, x);
            // lp.printList(head);

            // P_LinkedList ll = new P_LinkedList();

            // ll.InsertAtFront(1);
            // ll.newNode(5);
            // ll.newNode(10);
            // ll.newNode(20);
            // ll.Print();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            int d = 2;

            if (d > n)
                d %= n;

            ArrPractise.LeftRotate(arr, 3, n);
            ArrPractise.PrintArray(arr);
        }

        static SinglyLinkedList SingleLinkedListCaller()
        {
            HelperSLL objHelper = new HelperSLL();
            SinglyLinkedList myLinkedList = new SinglyLinkedList();

            objHelper.InsertFront(myLinkedList, 1);
            // objHelper.InsertAfter(myLinkedList, 0, 1);
            objHelper.InsertAfter(myLinkedList, 1, 2);
            objHelper.InsertAfter(myLinkedList, 2, 3);
            objHelper.InsertAfter(myLinkedList, 3, 4);
            objHelper.InsertAfter(myLinkedList, 4, 5);
            objHelper.InsertAfter(myLinkedList, 5, 6);
            objHelper.InsertLast(myLinkedList, -1);
            // Console.WriteLine();

            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
            Console.WriteLine("==================");
            return myLinkedList;
            // objHelper.ReverseLinkedList(myLinkedList);
            // Console.WriteLine();
            // objHelper.FindMiddle(myLinkedList);
            // objHelper.GetLastNode(myLinkedList);
        }

        // static void DoubleLinkedListCaller()
        // {
        //     HelperDLL objHelper = new HelperDLL();
        //     DoublyLinkedList myDoubly = new DoublyLinkedList();

        //     objHelper.InsertFront(myDoubly, 3);
        //     objHelper.InsertFront(myDoubly, 1);
        //     objHelper.PrintList(myDoubly);
        //     Console.WriteLine();
        //     objHelper.InsertLast(myDoubly, 5);
        //     objHelper.PrintList(myDoubly);
        //     // objHelper.GetLastItem(myDoubly);
        // }
    }
}