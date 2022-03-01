using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilephone
{
    internal class Program
    {
        public static List<Mobile> mobiles = new List<Mobile>();
        static void Main(string[] args)
        {
            MobileFactory phone = new MobileFactory();
            phone.Storage = 500;
            phone.Memory = 16;
            phone.ScreenSize = 5.1;

            Factory(phone, ConsoleColor.Blue, 10);
            Factory(phone, ConsoleColor.Red, 5);

            foreach (Mobile mobile in mobiles)
            {
                Console.WriteLine(mobile);
            }

            Console.ReadLine();
        }

        public static void Factory(Mobile prototype, ConsoleColor color, int count)
        {
            MobileFactory mobile = new MobileFactory();
            mobile.SetPrototype(prototype);
            for (int i = 0; i < count; i++)
            {
                mobiles.Add(mobile.Produce(color));
            }
        }
    }
}
