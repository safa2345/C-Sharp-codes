using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_c_sharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deaclaration of 2d array
            int[,] input = {
                { 1, 2, 3, 4, 5, },
                {2 ,76, 9, 0, 67 },
                {56, 65, 98, 45, 7 },
                };
            Console.WriteLine(input[0,0]);
            Console.WriteLine(input[1,0]);
            Console.WriteLine(input[1,4]);
            Console.WriteLine(input[2,4]);

            //another way
            int[,] output = new int[3, 4] {
                                          { 5, 6, 09, 56,},
                                          { 4, 3, 43, 29},
                                          { 7, 76, 65, 89},
                                           };

            Console.WriteLine(output[1,2]);


            Console.ReadLine();

        }


       

    }
}
