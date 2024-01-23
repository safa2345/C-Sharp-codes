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
            Console.Write("Enter a number: ");
            double no_1= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:" );
            double no_2 = Convert.ToDouble(Console.ReadLine()) ;


            Console.Write("Enter another number: ");
            double no_3 = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("which opration u want to perform");
            string op=Console.ReadLine();




            if (op == "+")
            {

                Console.WriteLine(no_1 + no_2 + no_3);
            }
            else if (op == "-") 
            {
                Console.WriteLine(no_1 - no_2 - no_3);
            }
            else if(op == "*")
            {

                Console.WriteLine(no_1 * no_2 * no_3);
            }
            else if (op == "/")
            {
                Console.WriteLine(no_1 / no_2 / no_3);
            }


            Console.ReadLine();
        }


   
    }
}
