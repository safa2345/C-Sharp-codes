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
            //1st way
            Console.WriteLine(cube_number(2));

            //2nd way
            int store=cube_number(8);
            Console.WriteLine(store);

            Console.ReadLine();
        }

    static int cube_number(int p)
        {
            int result = p * p * p;
          
            return result;
        }
    }
}
