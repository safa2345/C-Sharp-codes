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
            Show_the_number(56);//calling the method

            Show_the_number(56758769);

            Show_the_number(67.55);


            Console.ReadLine();
        }

    static void Show_the_number(double p)
        {
            
            Console.WriteLine("It is " + p);
        }
    }
}
