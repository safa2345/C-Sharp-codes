using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_c_sharp_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter a number: ");
                int no_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number:");
                int no_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(no_1 / no_2);
            }

            //1st method
            /*
           catch //this catch will catch all types of catch
            {


              Console.WriteLine("error");
            }
            */

            //2nd method

           catch(Exception e)  //this catch will also catch all types of catch with printing exception names
          {
              Console.WriteLine(e.Message);
           }

            //3rd method

         /*
            catch (DivideByZeroException e)  //this catch will catch only divide 0 exceptions
            {
                Console.WriteLine(e.Message);
            }


            catch (FormatException e)  //this catch will catch only not int type exception
            {
                Console.WriteLine(e.Message);
            }
         */
           Console.ReadLine();

        }
    }
}
