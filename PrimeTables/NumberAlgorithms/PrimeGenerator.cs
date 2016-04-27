using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTables.NumberAlgorithms
{
    /// <summary>
    /// A class used to generate the first N prime numbers
    /// </summary>
    public class PrimeGenerator : NumberAlgorithm
    {
        private AlgorithmParameter<int> numberOfPrimes;

        public PrimeGenerator(AlgorithmParameter<int> numberOfPrimes)
        {
            this.numberOfPrimes = numberOfPrimes;
        }

        public override int[] Run()
        {
            //TODO: Validate the parameter
            return null;
        }
    }
}
