using Microsoft.VisualStudio.TestTools.UnitTesting;
using NikitinAN_01_07;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQPtrue()
        {
            WiresP wp = new WiresP(100, 20, true);
            Assert.AreEqual(wp.Qp(), 0.4);
        }
        [TestMethod]
        public void TestQPfalse ()
        {
            WiresP wp = new WiresP(10, 20, false);
            Assert.AreEqual(wp.Qp(), 1.4);
        }
        [TestMethod]
        public void TestQ ()
        {
            WiresP wp = new WiresP(10, 20, false);
            Assert.AreEqual(wp.Q(), 2);
        }
        [TestMethod]
        public void wires ()
        {
            Wires w = new Wires(5, 30);
            Assert.AreEqual(w.Q(), 6);
        }
    }
}
