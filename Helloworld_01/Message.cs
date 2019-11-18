using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    class Message
    {

        private void GetHelloMessage(out string salut)
        {
            // Console.WriteLine("\nQuel est ton nom ?");
            // var name = Console.ReadLine();
            salut = "";
            var date = DateTime.Now;
            if (date.ToString("ddd") == "sam." | date.ToString("ddd") == "dim." | date.ToString("ddd") == "ven." & date.Hour >= 18 | date.ToString("ddd") == "lun." & date.Hour < 9)
            {
                salut = "Bon week-end";
                //Console.WriteLine($"\nBon week-end, {name}, le {date:d} à {date:t} !");
                // var salut = "Bon week-end";
                // return Salut;
            }
            else
            {
                if (date.Hour >= 9 && date.Hour < 13)
                {
                    salut = "Bonjour";
                    // Console.WriteLine($"\nBonjour, {name}, le {date:d} à {date:t} !");
                    // Salut = "Bonjour";
                    // return Salut;
                }
                else if (date.Hour >= 13 && date.Hour < 18)
                {
                    salut = "Bon après-midi";
                    // Console.WriteLine($"\nBon après-midi, {name}, le {date:d} à {date:t} !");
                    // Salut = "Bon après-midi";
                    // return Salut;
                }
                else if (date.Hour >= 18 && date.Hour < 24 || date.Hour >= 0 && date.Hour < 9)
                {
                    salut = "Bon soir";
                    // Console.WriteLine($"\nBon soir, {name}, le {date:d} à {date:t} !");
                    // Salut = "Bon soir";
                    // return Salut;
                }
            }
        }

        public void ShowMessage()
        {
            string salut;
            GetHelloMessage(out salut);
            var date = DateTime.Now;

            Console.WriteLine("\nQuel est ton nom ?");
            var name = Console.ReadLine();

            Console.WriteLine($"\n{salut}, {name}, le {date:d} à {date:t} !");
        }
    }
}
