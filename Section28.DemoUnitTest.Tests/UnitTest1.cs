using Microsoft.VisualStudio.TestTools.UnitTesting;
using Section28.DemoUnitTest.CLB;

namespace Section28.DemoUnitTest.Tests
{
    [TestClass]
    public class MathClassUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            int x = 5;
            int y = 7;
            int z = x + y;
            MathClass mathClass = new MathClass();
            var result = mathClass.Add(x, y);
            Assert.AreEqual(z,result);
        }
        [TestMethod]
        public void SubtractTest()
        {
            int x = 5;
            int y = 7;
            int z = x - y;
            MathClass mathClass = new MathClass();
            var result = mathClass.Subtract(x, y);
            Assert.AreEqual(z, result);
        }
    }
}
