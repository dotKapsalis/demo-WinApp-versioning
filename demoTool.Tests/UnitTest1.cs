using demoTool.Desktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace demoTool.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ShouldReturnSum_WhenTwoIntegersProvided()
        {
            Calculator calculator = new Calculator();

            int result = calculator.AddNumbers(2, 3);

            Assert.AreEqual(5, result);
        }
    }
}
