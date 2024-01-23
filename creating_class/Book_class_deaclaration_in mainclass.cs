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
            Book_class b1=new Book_class();

            b1.book_name = "peace";
            string r= b1.title = "peace of mind";
            b1.page_no();

            Console.WriteLine(b1.book_name);//one way
            Console.WriteLine(r);//2nd way

            Console.ReadLine();



        }
    }
}
