using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerShareKKopiecExercise;
namespace UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorPicksCorrectData()
        {
            //Arrange
            var bestPurchaseDateValue = new Tuple<int, double>(2, 8.0);
            var bestSellDateValue = new Tuple<int, double>(5, 13.0);
            List<Tuple<int, double>> data = new List<Tuple<int, double>>();
            data.Add(new Tuple<int, double>(1, 9.0));
            data.Add(bestPurchaseDateValue);
            data.Add(new Tuple<int, double>(3, 10.5));
            data.Add(new Tuple<int, double>(4, 9.5));
            data.Add(bestSellDateValue);
            data.Add(new Tuple<int, double>(6, 10.0));

            //Act
            var result = Calculator.BestPurchaseSale(data);

            //Assert
            Assert.AreEqual(bestPurchaseDateValue, result.Item1, "Purchase Date/Value is incorrect");

            Assert.AreEqual(bestSellDateValue, result.Item2, "Sell Date/Value is incorrect");
        }
        [TestMethod]
        public void CalculatorfeddWithTheSameData()
        {
            //Arrange
            var bestPurchaseDateValue = new Tuple<int, double>(1, 8.0);
            var bestSellDateValue = new Tuple<int, double>(2, 8.0);
            List<Tuple<int, double>> data = new List<Tuple<int, double>>();
            data.Add(bestPurchaseDateValue);
            data.Add(bestSellDateValue);
            data.Add(new Tuple<int, double>(3, 8));
            data.Add(new Tuple<int, double>(4, 8));
            data.Add(new Tuple<int, double>(5, 8));
            data.Add(new Tuple<int, double>(6, 8));
            data.Add(new Tuple<int, double>(7, 8));

            //Act
            var result = Calculator.BestPurchaseSale(data);

            //Assert
            Assert.AreEqual(bestPurchaseDateValue, result.Item1, "Purchase Date/Value is incorrect");

            Assert.AreEqual(bestSellDateValue, result.Item2, "Sell Date/Value is incorrect");
        }
        [TestMethod]
        public void CalculatorfeddWithSingleData()
        {
            //Arrange
            var bestPurchaseDateValue = new Tuple<int, double>(1, 8.0);
            var bestSellDateValue = new Tuple<int, double>(1, 8.0);
            List<Tuple<int, double>> data = new List<Tuple<int, double>>();
            data.Add(bestPurchaseDateValue);

            //Act
            var result = Calculator.BestPurchaseSale(data);

            //Assert
            Assert.AreEqual(bestPurchaseDateValue, result.Item1, "Purchase Date/Value is incorrect");

            Assert.AreEqual(bestSellDateValue, result.Item2, "Sell Date/Value is incorrect");
        }
        [TestMethod]
        public void CalculatorfeddWithEmptyData()
        {
            //Arrange
           
            
            List<Tuple<int, double>> data = new List<Tuple<int, double>>();
            

            //Act
            var result = Calculator.BestPurchaseSale(data);

            //Assert

            Assert.IsNull(result.Item1, "Item one is not null");
            Assert.IsNull(result.Item2, "Item two is not null");
        }
    }
}
