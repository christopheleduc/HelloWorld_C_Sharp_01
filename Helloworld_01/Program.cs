using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine(date.ToString("ddd"));
            Salutation.Afficher();
            GetHelloMessage.Politess();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
