using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = 27;
            float result = Lab1_1.Program.SerArh(a, b);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 3;
            int b = 27;
            float result = Lab1_1.Program.SerGeo(a, b);
            Assert.AreEqual(9, result);
        }
    }
}
