using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    class Salutation
    {
        public void Afficher()
        {
            Console.WriteLine("\nQuel est ton nom ?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            if (name != "Code Killer")
            {
                Console.WriteLine($"\nBonjour, {name}, le {date:d} à {date:t} !");
            }
            else
            {
                Console.WriteLine($"\nBonjour Maître, le {date:d} à {date:t} !");
            }
        }
    }
}
