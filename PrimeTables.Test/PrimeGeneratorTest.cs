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
            AlgorithmParameter<int> invalidParam = null;
            PrimeGenerator p = new PrimeGenerator(invalidParam);
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
            AlgorithmParameter<int> invalidParam = 
                new AlgorithmParameter<int>()
                {
                    Value = 0
                };

            PrimeGenerator p = new PrimeGenerator(invalidParam);
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
            AlgorithmParameter<int> invalidParam =
                new AlgorithmParameter<int>()
                {
                    Value = -1
                };

            PrimeGenerator p = new PrimeGenerator(invalidParam);
            int[] result = p.Run();
        }
    }
}
