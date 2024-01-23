using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_trasnpose
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i, j;
            int[,] arr1 = new int[30, 30];
            int[,] arr2 = new int[30, 30];

            Console.Write("\nEnter the number of rows and columns of the matrix :\n");
            Console.Write("Rows entered = ");
            int  m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Columns entered = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Set elements in the matrix...\n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"\n [{i}],[{j}] : ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\n\nMatrix before Transpose:\n");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {

                    arr2[j, i] = arr1[i, j];
                }
            }

            Console.Write("\n\nMatrix after Transpose: ");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }


 
    }


    }


