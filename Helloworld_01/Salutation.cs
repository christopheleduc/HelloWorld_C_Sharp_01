using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    public class Salutation
    {
        public string Afficher(string name="")
        {
            string retourConsole;
            if (name=="")
            {
                Console.WriteLine("\nQuel est ton nom ?");
                name = Console.ReadLine();
            }
            var date = DateTime.Now;
            if (name != "Code Killer")
            {
                retourConsole = ($"\nBonjour, {name}, le {date:d} à {date:t} !");
                Console.WriteLine($"\nBonjour, {name}, le {date:d} à {date:t} !");
            }
            else
            {
                retourConsole = ($"\nBonjour Maître, le {date:d} à {date:t} !");
                Console.WriteLine($"\nBonjour Maître, le {date:d} à {date:t} !");
            }
            return retourConsole;
        }
    }
}
