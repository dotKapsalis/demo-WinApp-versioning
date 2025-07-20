using demoTool.Desktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Windows.Forms;

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

        [TestMethod]
        public void ShoudDevideTwoNumbersByZero()
        {
            const float expected = 0;
            const float aValue = 10;
            const float bValue = 0;

            float answer = Calculator.DivideNumbers(aValue, bValue);

            Assert.AreEqual(expected, answer);
        }

        [TestMethod]
        public void Form1_HasButton1_WithCorrectDefaults()
        {
            using (var form = new Form1())
            {
                var button = form.Controls.Find("button1", true).FirstOrDefault() as Button;

                Assert.IsNotNull(button);
                Assert.AreEqual("Start", button.Text);
                Assert.IsTrue(button.Enabled);
            }
        }
    }
}
