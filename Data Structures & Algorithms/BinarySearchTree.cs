using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_Tree
{
    class T_Node
    {
        public int data;
        public T_Node left, right, root;
        public  T_Node()
        {
            right = null;
            root = null;
            left = null;
            data = 0;
        }
        public T_Node(int input)
        {
            data = input;
            right = null;
            left = null;
            root = null;
        }

    }
    class BinarySearchTree
    {
      public  T_Node startroot=new T_Node();
       public BinarySearchTree()
        {
           
        }
        public void Insert(int val)
        {
            if ( startroot.data== 0)
            {
                startroot.data = val;

            }
            else
            {
                T_Node n = new T_Node(val);
                T_Node temp = startroot;
                while ((temp.left != null)||(temp.right!=null))
                {
                    if (val < temp.data)
                    {
                        if (temp.left == null) break;
                        else
                        {
                                temp = temp.left;
                                continue;
                        }
                    }
                    else
                    {
                        if (temp.right == null) break;
                        else
                        {
                            temp = temp.right;
                            continue;
                        }
                       
                    }
                   
                }
                if ((val >temp.data))
                {
                    temp.right = n;
                    n.root = temp;
                }
                else 
                {
                    temp.left = n;
                    n.root = temp;
                }
            }
        }
       public T_Node Search(int val)
        {
            T_Node current = startroot;
            while (current.data!=val)
            {
                if(val<current.data)
                {
                    current=current.left;
                }
                else
                {
                    current = current.right;
                }
                if(current==null)
                {
                    return null;
                }
            }
            return current;
        }
        public T_Node Min(T_Node current)
        {
             //current = startroot;
            while(current.left!=null)
            {
                current = current.left;
            }
            return current;
        }
        public T_Node Max()
        {
            T_Node current = startroot;
            while (current.right != null)
            {
                current = current.right;
            }
            return current;
        }
        public T_Node Delete(T_Node root,int key)
        { 
            if (root == null) return root;
            if (key < root.data)
                root.left = Delete(root.left, key);
            else if (key > root.data)
                root.right = Delete(root.right, key);
            else
            {
                if (root.left == null)
                {
                    T_Node temp = root.right;
                    root.data = temp.data;
                    return temp;
                }
                else if (root.right == null)
                {
                    T_Node temp = root.left;
                    root.data = temp.data;
                    return temp;

                }
                else
                {

                    T_Node temp = Min(root.right);
                    root.data = temp.data;
                    if (temp.right == null && temp.left == null)
                    {
                        if (temp.root.data < temp.data)
                            temp.root.right = null;
                        if (temp.root.data > temp.data)
                            temp.root.left = null;
                    }
                }
            }
            return root;

        }
            public void Dispaly (T_Node root1)
        {
           if (root1==null)
            {
                return;
            }
           else
            {
                Dispaly(root1.left);
                Console.WriteLine(root1.data);
                Dispaly(root1.right);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // BinarySearchTree bst = new BinarySearchTree();
            // //T_Node n = new T_Node();
            // Console.WriteLine("Enter any value for root");
            // int a = int.Parse(Console.ReadLine());
            // bst.Insert(a);
            // string ans = "";
            // Console.WriteLine("Do you wish to Continue?");
            // ans = Console.ReadLine();
            //ans= ans.ToUpper();
            // if(ans=="YES")
            // {
            //     do
            //     {
            //         Console.WriteLine("Enter any number?");
            //         a = int.Parse(Console.ReadLine());
            //         bst.Insert(a);
            //         Console.WriteLine("Do you wish to Continue?");
            //         ans = Console.ReadLine();
            //         ans=ans.ToUpper();
            //     } while (ans == "YES");
            // }
            // Console.WriteLine("Output for inorder postfix");

            // bst.Dispaly(bst.startroot);
            // Console.WriteLine("Value to search");
            // int n = int.Parse(Console.ReadLine());
            // Console.WriteLine("After Search:{0}", bst.Search(n).data);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(12);
            bst.Insert(11);
            bst.Insert(18);
            Console.WriteLine("Output for inorder postfix");
            bst.Dispaly(bst.startroot);
            bst.Delete(bst.startroot, 10);
            Console.WriteLine("Output for inorder postfix after delete");
            bst.Dispaly(bst.startroot);
        }
    }
}
