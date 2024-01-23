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
            String colour, age;

            Console.Write("guess color: ");
            colour=Console.ReadLine();

            Console.Write("guess age: ");
            age = Console.ReadLine();

            Console.WriteLine("it is " + colour);
            Console.WriteLine("age is " + age);




            Console.ReadLine();
        }
    }
}
