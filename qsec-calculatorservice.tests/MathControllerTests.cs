using Microsoft.VisualStudio.TestTools.UnitTesting;
using qsec_calculatorservice.Controllers;
using qsec_calculatorservice.Models;

namespace qsec_calculatorservice.tests
{
    [TestClass]
    public class MathControllerTests
    {
        private MathController mathController;
        public MathControllerTests()
        {
            mathController = new MathController();
        }
        //4,2 should generate the response 2.
        [TestMethod]
        public void Test_Substracting_Ints_Returns_Correct_Answer()
        {
            var result = mathController.Substract(4, 2);
            Assert.AreEqual(result, 2);
        }

        // 11.5, 12.5 should generate the response -1
        [TestMethod]
        public void Test_Substracting_Decimal_Returns_Correct_Answer()
        {
            var result = mathController.Substract(11.5,12.5);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void Test_Addition_Int_Returns_Correct_Answer() {
            var result = mathController.Add(new BinaryOperands(2,4));
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void Test_Addition_Decimal_Returns_Correct_Answer() {
            var result = mathController.Add(new BinaryOperands(11.5M, 12.5M));
            Assert.AreEqual(result, 24);
        }
    }
}
