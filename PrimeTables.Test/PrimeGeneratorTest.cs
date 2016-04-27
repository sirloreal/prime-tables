using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeTables.NumberAlgorithms;

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
            int[] result = p.Run();
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
            int[] result = p.Run();
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
            int[] result = p.Run();
        }

        /**
         * Tests that if we ask for the first prime number that we get two 
         * back and no other numbers
         */
        [TestMethod]
        public void TestInputOneGivesOnlyTwo()
        {
            PrimeGenerator p = new PrimeGenerator(GetNumberParam(1));
            int[] result = p.Run();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
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
            int[] result = p.Run();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
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
