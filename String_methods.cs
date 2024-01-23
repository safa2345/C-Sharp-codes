using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String p = "My Hometown";
         

            Console.WriteLine(p.Length); //Length of a String
           

            Console.WriteLine(p.ToLower()); //ALL letter in lowercase
           

            Console.WriteLine(p.ToUpper()); //All letter in uppercase
           

            Console.WriteLine(p.Contains("Hometown")); // check if hometown word is in string p
           

            Console.WriteLine(p.Contains("Room")); //check if Room word is in string p
         

            Console.WriteLine(p[0]); //1st letter print
           

            Console.WriteLine(p[8]); //9th letter print(at index no 8)
           

            Console.WriteLine(p.IndexOf("town")); //From what index it started in string p
           

            Console.WriteLine(p.IndexOf('y')); //From what index it started in string p
          

            Console.WriteLine(p.Substring(9));
          

            Console.WriteLine(p.Substring(6,3));
          

            String q = "It is Beautiful";

            //comparing two string
            bool r = p.Equals(q);
            Console.WriteLine(r);
          

            //adding another string
            q = String.Concat(q, " world");
            Console.WriteLine(q);
           

            //check if string q is started with t
            Console.WriteLine(q.StartsWith("t"));
         


            //check if string q is started with l
            Console.WriteLine(q.EndsWith("l"));
           

            //replace
            Console.WriteLine(q.Replace("t", "m"));
        

            Console.ReadLine();

















            Console.ReadLine();
        }
    }
}
