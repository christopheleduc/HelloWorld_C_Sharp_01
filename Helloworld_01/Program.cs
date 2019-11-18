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
            Salutation salutation = new Salutation();
                salutation.Afficher();
            // Salutation.Afficher();
            Message message = new Message();
                message.ShowMessage();
            Console.WriteLine("\nReturn to continue / type 'exit' to quit !");
            var capture = Console.ReadLine();
            while (capture != "exit")
            {
                message.ShowMessage();
                Console.WriteLine("\nReturn to continue / type 'exit' to quit !");
                capture = Console.ReadLine();
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
