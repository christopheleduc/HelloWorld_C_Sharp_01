using System;
using System.Collections.Generic;
using System.Text;
using Helloworld_01;

namespace UnitTestProject2
{
    internal class FakeDate : IDate
    {
        public DateTime GetDate()
        {
            throw new NotImplementedException();
        }
    }
}
