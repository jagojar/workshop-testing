using NUnit.Framework;

namespace CalculatorUnitExample.Tests
{
    public class Tests
    {
        private CalculatorEngine calcEngine;

        [SetUp]
        public void Setup()
        {
            calcEngine = new CalculatorEngine();
        }

        [Test]
        public void Sum_3_Plus_4_Result_7()
        {
            var result = calcEngine.Sum(3, 4);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Substract_4_Minus_3_Result_1()
        {
            var result = calcEngine.Substract(4, 3);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Multiply_3_Times_4_Result_12()
        {
            var result = calcEngine.Multiply(3, 4);

            Assert.AreEqual(12, result);
        }

        [Test]
        public void Divide_4_by_2_Result_2()
        {
            var result = calcEngine.Divide(4, 2);

            Assert.AreEqual(2, result);
        }
    }
}