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

            Console.Write("Enter a number: ");
            int no_1 = Convert.ToInt16(Console.ReadLine());


            Console.Write("Enter a power: ");
            int no_2 = Convert.ToInt16(Console.ReadLine());



            int d = GetExp(no_1,no_2);
            Console.WriteLine("Answer is " + d);


            Console.ReadLine();

        }


        static int GetExp(int num,int pow)
        {
            int result = 1;

            for(int i=1;i<=pow;i++)
            {
                result = result * num;
            }

            return  result;


        }

    }
}
