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
            Console.Write("Enter a number: ");
            int no_1= Convert.ToInt16(Console.ReadLine());


            String d = GetDayName(no_1);
            Console.WriteLine("Today is " + d);
          

            Console.ReadLine();
        }

        static String GetDayName(int daynum)
        {
            String dayname;

            switch (daynum)
            {
                case 1:
                    dayname = "Sunday";
                    break;
                case 2:
                    dayname = "Monday";
                    break ;
                case 3:
                    dayname = "Tuesday";
                    break;
                case 4:
                    dayname = "Wednesday";
                    break;
                case 5:
                    dayname = "Thrusday";
                    break;
                case 6:
                    dayname = "Friday";
                    break;
                case 7:
                    dayname = "Saturday";
                    break;
                default:
                    dayname="invalid"
                        break;
 
            }

            return dayname;


        }
   
    }
}
