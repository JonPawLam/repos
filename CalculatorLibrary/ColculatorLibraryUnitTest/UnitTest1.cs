using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColculatorLibraryUnitTest
{

    /// <summary>
    /// Denne klasse tester metoderne fra CalculatorLibraryCore
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        //Skaber en calculator
        CalculatorLibraryCore.CalculatorClass calculator = new CalculatorLibraryCore.CalculatorClass();


        // Tester plus metoden

        [TestMethod]
        public void TestPlus()
        {
            try
            {
                double result = calculator.plus(10, 20);
                Console.WriteLine(result);
                double expected = 30;
                Assert.AreEqual(result , expected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
                throw;
            }
    
        }


        // Tester minus metoden

        [TestMethod]
        public void TestMinus()
        {
            try
            {
                double result = calculator.Minus(10, 5);
                double expected = 5;
                Assert.AreEqual(result, expected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // Tester Gange metoden

        [TestMethod]
        public void TestMultiply()
        {
            try
            {
                double result = calculator.Multiply(2, 2);
                double expected = 4;
                Assert.AreEqual(result, expected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        // Tester divider metoden

        [TestMethod]
        public void TestDevide()
        {
            try
            {
                double result = calculator.Divide(2, 2);
                double expected = 1;
                Assert.AreEqual(result, expected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
