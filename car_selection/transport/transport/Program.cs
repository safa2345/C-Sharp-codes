using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("select a car  \n 1.bmw \n 2.toyota \n 3.tesla \n");

            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                     Activity.info(select);
                    break; 
                case 2:
                    Activity.info(select);
                    break;
                case 3:
                    Activity.info(select);
                    break;
            }

            Console.ReadLine();
        }
    }
}
