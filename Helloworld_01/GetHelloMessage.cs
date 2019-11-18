using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    class GetHelloMessage
    {
        public static void Politess()
        {
            Console.WriteLine("\nQuel est ton nom ?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            if (date.ToString("ddd") == "sam." | date.ToString("ddd") == "dim." | date.ToString("ddd") == "ven." & date.Hour >= 18 | date.ToString("ddd") == "lun." & date.Hour < 9)
            {
                Console.WriteLine($"\nBon week-end, {name}, le {date:d} à {date:t} !");
            }
            else
            {
                if (date.Hour >= 9 && date.Hour < 13)
                {
                    Console.WriteLine($"\nBonjour, {name}, le {date:d} à {date:t} !");
                }
                else if (date.Hour >= 13 && date.Hour < 18)
                {
                    Console.WriteLine($"\nBon après-midi, {name}, le {date:d} à {date:t} !");
                }
                else if (date.Hour >= 18 && date.Hour < 24 || date.Hour >= 0 && date.Hour < 9)
                {
                    Console.WriteLine($"\nBon soir, {name}, le {date:d} à {date:t} !");
                }
            }
        }
    }
}