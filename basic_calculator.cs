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
            Console.Write("Enter a number :");
            //int number1 = Console.ReadLine();//it will give error as console readline always take everything as string so we have to convert it into integer
            double number1 =Convert.ToDouble( Console.ReadLine());


            Console.Write("Enter a number :");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number1 + number2);


            Console.ReadLine();
        }
    }
}
