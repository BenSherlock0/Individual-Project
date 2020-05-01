using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Individual_Project;

namespace btnNums_Click.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SameNums()
        {
            Entry testNums = new Entry(5,5,5,DateTime.Now);
            bool expectedAnswer = true;

            testNums.findCopy(testNums.Num1, testNums.Num2, testNums.Num3);

            Assert.AreEqual(expectedAnswer, testNums.Vaild);
        }
        [TestMethod]
        public void TwoSameNums()
        {
            Entry testNums = new Entry(5, 5, 20, DateTime.Now);
            bool expectedAnswer = true;

            testNums.findCopy(testNums.Num1, testNums.Num2, testNums.Num3);

            Assert.AreEqual(expectedAnswer, testNums.Vaild);
        }
        [TestMethod]
        public void DiffNums()
        {
            Entry testNums = new Entry(5, 13, 20, DateTime.Now);
            bool expectedAnswer = false;

            testNums.findCopy(testNums.Num1, testNums.Num2, testNums.Num3);

            Assert.AreEqual(expectedAnswer, testNums.Vaild);
        }

    }
}
