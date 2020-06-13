// using System;

// namespace algorithm_v2.LLProblems
// {
//     public class LNode
//     {
//         internal int data;

//         internal LNode next;

//         public LNode(int d)
//         {
//             data = d;
//         }
//     }

//     public class P_LinkedList
//     {
//         LNode head;

//         public void InsertAtFront(int item)
//         {

//             LNode head = this.head;

//             LNode newNode = new LNode(item)
//             {
//                 next = head
//             };

//             this.head = newNode;

//         }


//         public void newNode(int data)
//         {
//             LNode temp = this.head;
//             if (data == null) return;

//             LNode new_item_node = new LNode(data);
//             while (temp.next.data != -1)
//             {
//                 temp = temp.next;
//             }

//             temp.next = new_item_node;
//         }

//         public void Print()
//         {

//             LNode temp = head;

//             while (temp.data != -1)
//             {
//                 Console.Write(temp.data);
//                 temp = temp.next;
//             }

//             return;
//         }
//     }
// }