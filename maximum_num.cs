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
            Console.Write("Enter a number");
            int no_1= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number");
            int no_2 = Convert.ToInt32(Console.ReadLine());

            int result=getmax(no_1, no_2);
            Console.WriteLine("Maximum number is :" + result);







            Console.ReadLine();
        }

       static int getmax(int a,int b)
        {
            if(a > b)
            {
                
                return a;
            }
            else if(a < b)
            { 
                return b;
            }
            else
            {
                
                return -1;
            }




        }
   
    }
}
