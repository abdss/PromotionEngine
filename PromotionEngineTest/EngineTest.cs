using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineTest
{
    [TestClass]
    public class EngineTest
    {
        [TestMethod]
        public void TestBasicCalculationWithoutPromotionWithoutD()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(1,1,1,0);

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestBasicCalculationWithoutPromotionWithD()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(1, 1, 1, 1);

            Assert.AreEqual(115, result);
        }

        [TestMethod]
        public void TestPromotionA()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(3, 1, 1, 0);

            Assert.AreEqual(180, result);
        }
    }
}
