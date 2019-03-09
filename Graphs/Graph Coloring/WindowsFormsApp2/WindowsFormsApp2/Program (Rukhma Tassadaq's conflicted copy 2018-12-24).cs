using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Node
    {
        public string data;
        public Node next;
        public Node(string val)
        {
            data = val;
        }
        public Node()
        {

        }
    }
    class LinkedList
    {
        Node start;
        public LinkedList()
        {
            start = new Node();
        }
        public void InsertAtBeg(string val)
        {
            if (start.next == null)
            {
                Node n = new Node(val);
                start.next = n;
            }
            else
            {
                Node n = new Node(val);
                n.next = start.next;
                start.next = n;
            }
        }
    //    public void InsertAfter(int val, int after)
    //    {
    //        if (start.next == null)
    //        {
    //            Node n = new Node(val);
    //            start.next = n;
    //        }
    //        else
    //        {
    //            Node temp = start.next;
    //            while (temp.next != null)
    //            {
    //                if (temp.data == after)
    //                    break;
    //                else
    //                    temp = temp.next;
    //            }
    //            Node n = new Node(val);
    //            n.next = temp.next;
    //            temp.next = n;
    //        }
    //    }
    //    public void InsertAtEnd(int val)
    //    {
    //        if (start.next == null)
    //        {
    //            Node n = new Node(val);
    //            start.next = n;
    //        }
    //        else
    //        {
    //            Node temp = start.next;
    //            while (temp.next != null)
    //            {
    //                temp = temp.next;
    //            }
    //            Node n = new Node(val);
    //            n.next = temp.next;
    //            temp.next = n;
    //        }
    //    }
    //    public void DelFromBeg()
    //    {
    //        start.next = start.next.next;
    //    }
    //    public void DelAfter(int after)
    //    {
    //        Node temp = start.next;
    //        while (temp.next != null)
    //        {
    //            if (temp.data == after)
    //                break;
    //            else
    //                temp = temp.next;
    //        }
    //        temp.next = temp.next.next;
    //    }
    //    public void DelFromEnd()
    //    {
    //        Node temp = start.next;
    //        while (temp.next.next != null)
    //        {
    //            temp = temp.next;
    //        }
    //        temp.next = null;
    //    }
    //    public void Display()
    //    {
    //        Node temp = start.next;
    //        while (temp.next != null)
    //        {
    //            Console.Write(temp.data + " ");
    //            temp = temp.next;
    //        }
    //        Console.WriteLine(temp.data);
    //    }
   }
        static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
