using System;
namespace dsa.LinkedList
{
    public class ReversedLinkedList
    {
        public ListNode l1=null;
        
        public ReversedLinkedList()
        {
            Console.WriteLine("Linked List in reversed order");

            //Create a Linked List
            ListNode n1 = new ListNode(5);
            ListNode n2 = new ListNode(4,n1);
            ListNode n3 = new ListNode(3,n2);
            ListNode n4 = new ListNode(2,n3);
            ListNode n5 = new ListNode(1,n4);
            l1 = n5;
        }

        //Method
        public void reversedList()
        {
            Console.WriteLine("Before:");
            l1.Print(l1);
            ListNode head = l1;
            ListNode prev = null;
            while ( head != null)
            {
                ListNode current = head.next;
                head.next = prev;
                prev = head;

                head = current;
            }
            l1 = prev;
            Console.WriteLine("After");
            l1.Print(l1);
        }
    }
}
