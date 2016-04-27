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
            //Validate the parameter
            if(numberOfPrimes == null)
            {
                throw new ArgumentNullException("Paramter must not be null");
            }
            if(numberOfPrimes.Value < 1)
            {
                throw new ArgumentException("Number of primes must be greater than one");
            }
            


            return null;
        }
    }
}
