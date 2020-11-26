using System;
using System.Collections.Generic;
using ComputerShareKKopiecExcercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class IOHelpersTests
    {
        [TestMethod]
        public void CreateDatasetSuccess()
        {
            //Arrange
            string[] rawData = new string[] { "0.1", "22", "13.5" };
            List<Tuple<int, double>> expectedResult = new List<Tuple<int, double>>();
            expectedResult.Add(new Tuple<int, double>(1, 0.1));
            expectedResult.Add(new Tuple<int, double>(2, 22));
            expectedResult.Add(new Tuple<int, double>(3, 13.5));

            //Act
            var result = IOHelpers.CreateDataset(rawData);

            //Assert
            for (int i = 0; i < result.Count - 1; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i], "Expected Dataset does not match at position "+ i);
            }
        }
        [TestMethod]
        public void CreateDatasetFail()
        {
            //Arrange
            string[] rawData = new string[] { "0.1", "aa", "13.5" };
           //Act + Assert
            Assert.ThrowsException<FormatException>(() => IOHelpers.CreateDataset(rawData), "Cannot supply values other than double");

                    }
    }
}
