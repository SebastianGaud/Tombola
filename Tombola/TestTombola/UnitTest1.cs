using Cartellina;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTombola
{
    [TestClass]
    public class UnitTest1
    {
        private Cartellina.CartellinaController controller;

        [TestInitialize]
        public void TestInitialize ()
        {
            controller = new CartellinaController();
        }

        [TestMethod]
        public void ControllaLista ()
        {
            bool isNotEmpty = controller.NumeriCartellina.Length == 0 ? false : true;

            Assert.IsTrue( isNotEmpty , "La lista è vuota" );
        }
    }
}
