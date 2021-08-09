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
            var result = engine.CalculateOrderValue(1, 1, 0, 1);

            Assert.AreEqual(95, result);
        }

        [TestMethod]
        public void TestPromotionA()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(3, 1, 1, 0);

            Assert.AreEqual(180, result);
        }

        [TestMethod]
        public void TestPromotionB()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(1, 4, 1, 0);

            Assert.AreEqual(160, result);
        }

        [TestMethod]
        public void TestPromotionAandB()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(5, 5, 1, 0);

            Assert.AreEqual(370, result);
        }

        [TestMethod]
        public void TestPromotionCDwithSameQuantity()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(0, 0, 1, 1);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestPromotionCDwithMoreC()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(0, 0, 3, 1);

            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void TestPromotionCDwithMoreD()
        {
            var engine = new Engine();
            var result = engine.CalculateOrderValue(0, 0, 1, 3);

            Assert.AreEqual(60, result);
        }
    }
}
