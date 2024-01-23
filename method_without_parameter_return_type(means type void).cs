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
            Show_the_number();//calling the method
            
            Console.ReadLine();
        }

    static void Show_the_number()
        {
            String p=Console.ReadLine();

            Console.WriteLine("It is " + p);
        }
    }
}
