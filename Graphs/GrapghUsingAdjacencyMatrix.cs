using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALab13
{
   
    class Program
    {
        static void AdjacencyMatrix(char[,] arr,int nodes)
        {
            for (int i=1; i<=nodes;i++)
            {
                for(int j=1;j<=nodes;j++)
                {
                    if(arr[i,j]=='1')
                    {
                        Console.WriteLine("{0}-------->{1}", arr[0, j], arr[i, 0]);
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            Console.WriteLine("Please Enter Number of vertices");
            int n = int.Parse(Console.ReadLine());
            char[] arr = new char[n];
            for(int k =0; k<n;k++)
            {
                Console.Write("Element{0}", k+1);
                arr[k] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Start entering your Vertices");
            char [,] array = new char[n+1, n+1];
            int o = 0;
            array[0, 0] = '0';
            for (i=1;i<=n;i++ )
            {
                array[0, i] = arr[o];
                o++;
            }
            o = 0;
            for (j = 1; j <= n; j++)
            {
                array[j, 0] = arr[o];
                o++;
            }

            for ( i=1;i<=n;i++)
            {
                for ( j=1;j<=n;j++)
                {
                    Console.Write("Connected(1) Or Not(0)");
                    array[i, j] = Convert.ToChar(Console.ReadLine());
                }
                Console.WriteLine();
            }
            AdjacencyMatrix(array,n);
        }
    }
}
