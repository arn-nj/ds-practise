using System;
namespace dsa.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x=0, ListNode n=null)
        {
            val = x;
            next = n;
        }
        public ListNode(int x)
        {
            val = x;
        }

        public void Print(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val+"->");
                node = node.next;
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }
}
