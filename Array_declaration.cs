using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_code_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array normal

            int[] p1 = { 5, 8, 9, 3, 7 };
            Console.WriteLine(p1[2]);
            Console.WriteLine(p1[4]);

            //updated array value
            p1[4] = 21;

            Console.WriteLine(p1[4]);

            //another way of array declaration(telling the array size)
            String[] names = new string[7];
            names[0] = "hydra";//highest 7 ta neya jabe
            names[1] = "rix";
            names[6] = "gopher";
            Console.WriteLine(names);
            Console.WriteLine(names[0]);

            int[] q1 = new int[50];
            q1[0] = 5;
            q1 [1] = 6;
            Console.WriteLine(q1[1]);



            Console.ReadLine();
        }
    }
}
