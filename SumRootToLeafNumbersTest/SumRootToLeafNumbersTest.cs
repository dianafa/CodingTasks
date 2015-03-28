using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingTasks;
using System.Collections.Generic;

namespace CodingTasksTests
{
    [TestClass]
    public class SumRootToLeafNumbersTest
    {
        [TestMethod]
        public void ComputeSumTest()
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(3);
            int expected = 563;
            SumRootToLeafNumbers SRTLN = new SumRootToLeafNumbers();

            int actual = SRTLN.ComputeSum(numbers);

            Assert.AreEqual(expected, actual);
        }
    }
}
