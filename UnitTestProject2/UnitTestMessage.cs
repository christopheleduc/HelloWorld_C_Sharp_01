using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helloworld_01;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTestMessage
    {
        [TestMethod]
        public void MessageBonAMTest()
        {
            Message target = new Message();
            string salut = "";
            salut = "Bon après-midi";
            var date = System.DateTime.Now;
            string name = "christophe.leduc";
            string result = target.ShowMessage();
            //target.GetHelloMessage(ref date, out string salut);
            Assert.AreEqual($"\n{salut}, {name}, le {date:d} à {date:t} !", result);
        }
    }
}
