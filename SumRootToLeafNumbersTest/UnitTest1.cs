using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingTasks;

namespace CodingTasksTests
{
    [TestClass]
    public class SumRootToLeafNumbersTest
    {
        [TestMethod]
        public void ComputeSumTest()
        {
            int[] tab = { 5, 6, 3 };
            int expected = 563;
            SumRootToLeafNumbers SRTLN = new SumRootToLeafNumbers();

            int actual = SRTLN.ComputeSum(tab);

            Assert.AreEqual(expected, actual);
        }
    }
}
