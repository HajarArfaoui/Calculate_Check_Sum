using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateCheckDigit;
namespace CheckDigitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = CheckDigit.calculate_check_digit("71234567890");
            Assert.AreEqual(str, "712345678904");
        }
        //validate check sum
        [TestMethod]
        public void TestMethod2()
        {
            string str = CheckDigit.calculate_check_digit("01230000064");
            Assert.AreEqual(str, "012300000642");
        }
        //validate UPC-A code format
        [TestMethod]
        public void TestMethod3()
        {
            string str = CheckDigit.calculate_check_digit("7123@^@@4567890");
            Assert.AreEqual(str, "");
        }
        //validate UPC-A code length
        [TestMethod]
        public void TestMethod4()
        {
            string str = CheckDigit.calculate_check_digit("158896589963");
            Assert.AreEqual(str, "");
        }
        // check Empty String
        [TestMethod]
        public void TestMethod5()
        {
            string str = CheckDigit.calculate_check_digit("");
            Assert.AreEqual(str, "");
        }
    }
}
