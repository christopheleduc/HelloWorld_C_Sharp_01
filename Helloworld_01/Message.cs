using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    public class Message
    {

        private void GetHelloMessage(ref DateTime date, out string salut, int h1 = 9, int h2 = 13, int h3 = 18, int h4 = 24)
        {
            salut = "";
            //var date = DateTime.Now;
            if (date.ToString("ddd") == "sam." | date.ToString("ddd") == "dim." | date.ToString("ddd") == "ven." & date.Hour >= h3 | date.ToString("ddd") == "lun." & date.Hour < h1)
            {
                salut = "Bon week-end";
            }
            else
            {
                if (date.Hour >= h1 && date.Hour < h2)
                {
                    salut = "Bonjour";
                }
                else if (date.Hour >= h2 && date.Hour < h3)
                {
                    salut = "Bon après-midi";
                }
                else if (date.Hour >= h3 && date.Hour < h4 || date.Hour >= 0 && date.Hour < h1)
                {
                    salut = "Bon soir";
                }
            }
        }

        public string ShowMessage()
        {
            //string salut;
            //Console.WriteLine("UserName: {0}", Environment.UserName);
            string retourConsole;
            var date = DateTime.Now;

            GetHelloMessage(ref date, out string salut);

            //Console.WriteLine("\nQuel est ton nom ?");
            //var name = Console.ReadLine();
            var name = Environment.UserName;

            //Console.WriteLine($"\n{salut}, {name}, le {date:d} à {date:t} !");

            retourConsole = ($"\n{salut}, {name}, le {date:d} à {date:t} !");

            return retourConsole;
        }
    }
}
