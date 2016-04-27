using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeTables.NumberAlgorithms;
using System.Collections.Generic;

namespace PrimeTables.Test
{
    [TestClass]
    public class PrimeGeneratorTest
    {
        /**
         * The PrimeGenerator should not accept a null AlgorithmParameter
         */
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestNullInput()
        {
            PrimeGenerator p = new PrimeGenerator(null);
            List<int> result = p.Run();
        }

        /**
         * The number passed to the PrimeGenerator should be at least 1 and
         * we expect an ArgumentException to be raised when it is not
         */
        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestInputEqualsZero()
        {
            PrimeGenerator p = new PrimeGenerator(GetNumberParam(0));
            List<int> result = p.Run();
        }

        /**
         * Test that the generator does not accept negative values for
         * whatever reason
         */
        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestNegativeInput()
        {
            PrimeGenerator p = new PrimeGenerator(GetNumberParam(-1));
            List<int> result = p.Run();
        }

        /**
         * Tests that if we ask for the first prime number that we get two 
         * back and no other numbers
         */
        [TestMethod]
        public void TestInputOneGivesOnlyTwo()
        {
            PrimeGenerator p = new PrimeGenerator(GetNumberParam(1));
            List<int> result = p.Run();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(2, result[0]);
        }

        /**
         * Tests that if we ask for the first 2 prime numbers that we get two 
         * and three back 
         */
        [TestMethod]
        public void TestInputTwoGivesTwoAndThree()
        {
            PrimeGenerator p = new PrimeGenerator(GetNumberParam(2));
            List<int> result = p.Run();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
        }

        [TestMethod]
        public void TestInputFirstTenPrimes()
        {
            PrimeGenerator p = new PrimeGenerator(GetNumberParam(10));
            List<int> result = p.Run();

            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(7, result[3]);
            Assert.AreEqual(11, result[4]);
            Assert.AreEqual(13, result[5]);
            Assert.AreEqual(17, result[6]);
            Assert.AreEqual(19, result[7]);
            Assert.AreEqual(23, result[8]);
            Assert.AreEqual(29, result[9]);
        }

        private AlgorithmParameter<int> GetNumberParam(int value)
        {
            return new AlgorithmParameter<int>()
            {
                Value = value
            };
        }
    }
}
