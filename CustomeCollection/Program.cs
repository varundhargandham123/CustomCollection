using System;

namespace CustomCollection
{   
    class Program
    {
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
             {
                    data = d;
                    next = null;
             }
        }
        internal class VarunList
        {
            internal Node head=null;
        }/// <summary>
         /// this method is used to insert the node in last
         /// </summary>
         /// <param name="singlyList"></param>
         /// <param name="new_data"></param>
        static void InsertLast(VarunList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }
        /// <summary>
        /// this method is used to know the last node
        /// </summary>
        /// <param name="singlyList"></param>
        /// <returns></returns>
        static Node GetLastNode(VarunList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }/// <summary>
        /// this method is used to delete the node by taking key from the user
        /// </summary>
        /// <param name="singlyList"></param>
        /// <param name="key"></param>
        static void DeletebyKey(VarunList singlyList, int key)

        {
           Node temp = singlyList.head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
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
        }/// <summary>
        /// this method is to display
        /// </summary>
        /// <param name="slist"></param>
        static void Display(VarunList slist)
        {
            Node temp = slist.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }        
        }/// <summary>
        /// this deals with inserting inputs and diaplay the list
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            VarunList slist = new VarunList();
            InsertLast(slist,10);
            InsertLast(slist, 20);
            InsertLast(slist, 30);
            Display(slist);
            DeletebyKey(slist,10);
            Display(slist);
       }
    }
}
