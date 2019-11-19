using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld_01
{
    internal class Date : IDate
    {
        public DateTime GetDate()
        {
            //throw new NotImplementedException();
            DateTime date = DateTime.Now;
            return date;
        }
    }
}
