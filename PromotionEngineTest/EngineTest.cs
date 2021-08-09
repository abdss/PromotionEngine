using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineTest
{
    [TestClass]
    public class EngineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(1,1,1,0);

            Assert.AreEqual(100, result);
        }
    }
}
