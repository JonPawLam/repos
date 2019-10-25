using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skat;

namespace Skat_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// I disse regioner, tester vi min, max og middle bounderies af personbiler
        /// </summary>
        #region Personbil


        #region Personbil Min Values
        
        //personBil Test min value
        [TestMethod]
        public void PersonBilTestMinValueBilligBil()
        {
            double BilValue = 50000;
            string BilType = "PersonBil";
            double forventedResultat = 42500;

            double Result = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(forventedResultat,Result);
        }

        [TestMethod]
        public void PersonBilTestMinValueDyrBil()
        {
            double BilValue = 200001;
            string BilType = "PersonBil";

            double forventedResultat = 170001.5;
            
            double Result = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(forventedResultat, Result);
        }
        #endregion

        #region Personbil Max Values
        //personBil Test max value
        [TestMethod]
        public void PersonBilTestMaxValueBillig()
        {
            double BilValue = 200000;
            string BilType = "PersonBil";

            double ExpectedUdregning = 200000 * 0.85;

            double Resultat = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(ExpectedUdregning,Resultat);
        }

        //personBil Test Max realistisk dyr bil
        [TestMethod]
        public void PersonBilTestMaxValueRealistiskDyrBil()
        {
            double BilValue = 15000000;
            string BilType = "PersonBil";

            double ExpectedUdregning = 22370000;

            double Resultat = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(ExpectedUdregning,Resultat);
        }

        #endregion

        #region PersonBil Midle Values

        [TestMethod]
        //personBil Test Value Billige Mid Bil
        public void PersonBilTestBilligBilMidleBeløb()
        {
            double BilValue = 100000;
            string BilType = "PersonBil";

            double ExpectedUdregning = 100000 * 0.85;

            double Resultat = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(ExpectedUdregning, Resultat);
        }

        //personBil Test Value dyr Mid Bil
        public void PersonBilTesDyrBilMidleBeløb()
        {
            double BilValue = 400000;
            string BilType = "PersonBil";

            double ExpectedUdregning = 400000 * 0.85;

            double Resultat = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(ExpectedUdregning, Resultat);
        }
        
        #endregion

        #endregion

        /// <summary>
        ///     ElBil Test
        /// </summary>

        //ElBil Test min Billig elbil
        [TestMethod]
        public void ElBilTestMinValueBilligBil()
        {
            double BilValue = 1;
            string BilType = "Elbil";
            double forventedResultat = 0.17;

            double Result = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(forventedResultat, Result);
        }

        //ElBil Test min Dyr elbil 
        [TestMethod]
        public void ElBilTestMinValueDyrBil()
        {
            double BilValue = 200001;
            string BilType = "Elbil";

            double forventedResultat = 34000.3;

            double Result = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(forventedResultat, Result);
        }

        //Elbil Test Midle Billig
        [TestMethod]
        public void ElBilTestMidleBillig()
        {
            double BilValue = 50000;
            string BilType = "Elbil";

            double forventedResultat = 8500;

            double Result = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(forventedResultat, Result);
        }

        //Elbil Test Midle Dyr
        [TestMethod]
        public void ElBilTestMidleDyr()
        {
            double BilValue = 400000;
            string BilType = "Elbil";

            double forventedResultat = 94000;

            double Result = Skat.Afgift.BilAfgift(BilValue, BilType);
            Assert.AreEqual(forventedResultat, Result);
        }
    }
}
