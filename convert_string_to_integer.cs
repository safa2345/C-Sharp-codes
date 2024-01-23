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
            //int p = "32";//error dekhabe
          //  Console.WriteLine(p + 7);//String type so it will just show 327

            int q = Convert.ToInt16("32");
            Console.WriteLine(q + 7);





            Console.ReadLine();
        }
    }
}
