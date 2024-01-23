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
            Show_the_number(56,"medium");//calling the method

            Show_the_number(56758769,"old");

            Show_the_number(67.55,"new");


            Console.ReadLine();
        }

    static void Show_the_number(double p,String versions)
        {
            
            Console.WriteLine("It is " + p + " and " + versions);
        }
    }
}
