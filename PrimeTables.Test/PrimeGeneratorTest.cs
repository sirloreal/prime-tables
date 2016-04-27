using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeTables.NumberAlgorithms;

namespace PrimeTables.Test
{
    [TestClass]
    public class PrimeGeneratorTest
    {
        /**
         * The number passed to the PrimeGenerator should be > 1 and
         * we expect an ArgumentException to be raised when it is not
         */
        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestInputEqualsOne()
        {
            AlgorithmParameter<int> invalidParam = 
                new AlgorithmParameter<int>()
                {
                    Value = 1
                };

            PrimeGenerator p = new PrimeGenerator(invalidParam);
            int[] result = p.Run();
        }
    }
}
