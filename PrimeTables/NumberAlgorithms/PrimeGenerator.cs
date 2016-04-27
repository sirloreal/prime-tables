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

        public override List<int> Run()
        {
            List<int> results = new List<int>();
            //Validate the parameter
            if(numberOfPrimes == null)
            {
                throw new ArgumentNullException("Paramter must not be null");
            }
            if(numberOfPrimes.Value < 1)
            {
                throw new ArgumentException("Number of primes must be greater than one");
            }
            
            /**
             * 2 and three are known to be prime. We can add
             * 2 for free since we know the requested number of primes
             * is at least 1. Then, we can run the algorithm below starting from
             * the number 3
             */            
            results.Add(2);
            int nextPrime = 3;

            //Inspiration for initial algorithm sourced from stackoverflow:
            //http://stackoverflow.com/questions/1042902/most-elegant-way-to-generate-prime-numbers
            while (results.Count < numberOfPrimes.Value)
            {
                bool isPrime = true;            
        
                //TODO: Are there any possible pitfalls or missing numbers when using the results set for dividing?
                foreach (int n in results)
                {
                    if (nextPrime % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    results.Add(nextPrime);
                }

                //Get the next candidate number. Increase candidacy by 2 each
                //time since we know even numbers (save 2) will NOT be prime
                nextPrime += 2;
            }

            return results;
        }
    }
}
