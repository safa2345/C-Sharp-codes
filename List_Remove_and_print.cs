using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_trasnpose
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var fruit=new List<string> { "Apple" , "Water" ,"orange" , "pineapple" ,"egg", "mango"};

            fruit.Remove(fruit[1]);
            fruit.Remove(fruit[4]);

          foreach(var p in fruit)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
            

        }


 
    }


    }


