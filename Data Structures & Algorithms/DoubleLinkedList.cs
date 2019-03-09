using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    class D_Node
    {
        public int data;
        public D_Node next,pre;
        public D_Node()
        {
            next = null;
            data = 0;
        }
        public D_Node(int input)
        {
            data = input;
        }
       
    }
    class DC_LinkedList
    {
        private D_Node start = new D_Node(), end = new D_Node();
        public int lenght;
        public DC_LinkedList()
        {
            start.next = null;
            lenght = 0;
        }
       
        public void inserAtBegng(int val)
        {
            if (start.next == null)
            {
                D_Node n = new D_Node(val);
                start.next = n;
                end.pre = n;end.next = start.next;
                n.next = start.next;
            }
            else

            {
                D_Node temp;
                D_Node n = new D_Node(val);
                n.next = start.next;
                temp = start.next;
                temp.pre = n;
                start.next = n;
                end.next = start.next;
                n.next = start.next;
            }
        }
        public void insertAtEnd(int val)
        {
            if (start.next == null)
            {
                D_Node n = new D_Node(val);
                start.next = n;
                end.pre = n;end.next = start.next;
                n.next = start.next;
            }
            else
            {
                D_Node n = new D_Node(val);
                end.pre.next = n;
                n.pre = end.pre;
                end.pre = n; end.next = start.next;
                n.next = start.next;
            }
        }
        public void InsertATbetween(int inputval, int beforeValue)
        {
            bool flag = false; D_Node temp = start.next;
            while (temp.next != null)
            {
                if (temp.data == beforeValue)
                {
                    if (temp.next==null ) { insertAtEnd(inputval); flag = true; break; }
                   else
                    { D_Node n = new D_Node(inputval);
                        n.next = temp.next;
                        n.pre = temp;
                        temp.next.pre = n;
                        temp.next = n;
                        flag = true; break;
                    }
                }
                else { temp = temp.next; }
            }
           
        }
        public void Display(DC_LinkedList li)
        {
            D_Node temp = start.next;
            while (temp.next != start.next)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);


        }
        public void DeleteBeg()
        {
            start.next = start.next.next;
            start.next.pre = null;
        }
        public void DeleteEnd()
        {
            end.pre = end.pre.pre;
            end.pre.next = null;

        }
        public D_Node DeleteFrom(int val)
        {
            D_Node n = null; bool IS_DEL = false;
            D_Node temp = start.next;
            while (temp.next != null)
            {
                if (temp.data == val)
                {
                    
                    if (temp.next== end.pre) { n = temp.next; DeleteEnd(); IS_DEL = true; break; }
                    else
                    {
                        n = temp.next;
                        temp.next = temp.next.next;
                        temp.next.pre = n.pre; IS_DEL = true; break;
                    }
                }
                else
                {
                    temp = temp.next;
                }
            }
           
            return n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a;
            DC_LinkedList li = new DC_LinkedList();
            do
            {
                Console.WriteLine("Which option do you wish to choose?\n1)Insert At Beginning\n2)Insert At End" +
                    "\n3)Insert After \n4)Delete From Beginning \n5)Delete From End \n6)Delete From Between \n7)Exit \n8)Display\n9)Sort");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Write("Please enter a value to be inserted:");
                        int val = int.Parse(Console.ReadLine()); li.inserAtBegng(val);
                        break;
                    case 2:
                        Console.Write("Please enter a value to be inserted:");
                        int eval = int.Parse(Console.ReadLine());
                        li.insertAtEnd(eval);
                        break;
                    case 3:
                        Console.Write("Please enter a value to be inserted:");
                        int ival = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the value after which you wish to add?");
                        int mval = int.Parse(Console.ReadLine()); li.InsertATbetween(ival, mval);
                        break;
                    case 4: li.DeleteBeg(); break;
                    case 5: li.DeleteEnd(); break;
                    case 6:
                        Console.WriteLine("Entervalue:"); int i = int.Parse(Console.ReadLine());
                        li.DeleteFrom(i); break;
                    case 8: li.Display(li); break;
                
                }
            } while (a != 7);

        }
    }
    }
