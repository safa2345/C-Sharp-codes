using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_c_sharp_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b1=new using_constructor("harry pottee","adventure","many many many times ago",1090);

            Console.WriteLine(b1.title);
            Console.WriteLine(b1.description);
            Console.WriteLine(b1.page);

            var b2 = new using_constructor("Gta 5", 2139);

            Console.WriteLine(b2.book_name);
            Console.WriteLine(b2.page);

            var b3 = new using_constructor("this book is about weather information");
            Console.WriteLine(b3.description);







            Console.ReadLine();



        }
    }
}
