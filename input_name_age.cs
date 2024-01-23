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
            Console.Write("Enter Name:"); // it doesn,t create a new line so we can input the name in same line
            String p=Console.ReadLine(); //in p variable we will store the input strings ,after pressing enter given user_input will store in variable p
             

            Console.Write("Enter age :");
            String s=Console.ReadLine();//in console variable will be always in string ,if we give another data type ,error will be shown
            


            Console.WriteLine("Hello!My name is " + p + " & I'm " + s + " year old");//output of the given input
            Console.ReadLine();
        }
    }
}
