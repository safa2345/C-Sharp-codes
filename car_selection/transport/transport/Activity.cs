using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    internal class Activity
    {
        static BMW b=new BMW();
        static TOYOTA t=new TOYOTA();
        static TESLA s=new TESLA();

        public static void info(int select)
        {
            if (select == 1)
            {
                Console.WriteLine("bmw;s price " + b.getCarPrice() + " bmw;s color  " + b.getCarColor() + "bmw;s year " +b.getCarProductionYear());
            }


            if (select == 2)
            {
                Console.WriteLine("toys;s price " + t.getCarPrice() + " toyos color  " + t.getCarColor() + "toys year " + t.getCarProductionYear());
            }

            if (select == 3)
            {
                Console.WriteLine("tesla's price " + s.getCarPrice() + " tesla's color   " + s.getCarColor() + "tesla's year " + s.getCarProductionYear());
            }





        }

    }
}
