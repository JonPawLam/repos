
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maths;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0,0);
        }

        [TestMethod]
        public void BasicTest()
        {
            Maths.Rooter rooter = new Rooter();
            double expected = 0.0;
            double actual = rooter.SquareRoot(expected * expected);
            double tolerance = .001;
            Assert.AreEqual(expected, actual, tolerance);
        }

        [TestMethod]
        public void RootTest()
        {
            Rooter rooter = new Rooter();
            double expected = 1;
            double actual = rooter.SquareRoot(x: expected * expected);
            Assert.AreEqual(actual, expected);
            
        }


        // Verify that negative inputs throw an exception.
        [TestMethod]
        public void NegativeRangeTest()
        {
            string message;
            Rooter rooter = new Rooter();
            for (double v = -0.1; v > -3.0; v = v - 0.5)
            {
                try
                {
                    // Should raise an exception:
                    double actual = rooter.SquareRoot(v);

                    message = String.Format("No exception for input {0}", v);
                    Assert.Fail(message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    continue; // Correct exception.
                }
                catch (Exception e)
                {
                    message = String.Format("Incorrect exception for {0}", v);
                    Assert.Fail(message);
                }
            }
        }


        public double SquareRoot(double x)
        {
            double estimate = x;
            double diff = x;
            while (diff > estimate / 1000)
            {
                double previousEstimate = estimate;
                estimate = estimate - (estimate * estimate - x) / (2 * estimate);
                diff = Math.Abs(previousEstimate - estimate);
            }
            return estimate;
        }




    }
}
