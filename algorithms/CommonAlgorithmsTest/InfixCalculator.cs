using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonAlgorithms;

namespace CommonAlgorithmsTest
{
    [TestClass]
    public class InfixCalculatorTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            string expression = "(2*((9-1)/4))";
            InfixCalculation infixCalculator = new InfixCalculation();

           Assert.AreEqual(4, infixCalculator.Calculate(expression));
        }
    }
}
