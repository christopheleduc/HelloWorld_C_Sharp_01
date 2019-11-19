using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helloworld_01;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTestSalutation
    {
        [TestMethod]
        public void SalutationCodeKillerTest()
        {
            Salutation target = new Salutation();
            var date = System.DateTime.Now;
            string name = "Code Killer";
            string result = target.Afficher(name);
            Assert.AreEqual($"\nBonjour Maître, le { date:d} à { date:t} !", result);
        }

        [TestMethod]
        public void SalutationJohnDoeTest()
        {
            Salutation target = new Salutation();
            var date = System.DateTime.Now;
            string name = "John Doe";
            string result = target.Afficher(name);
            Assert.AreEqual($"\nBonjour, {name}, le { date:d} à { date:t} !", result);
        }
    }
}
