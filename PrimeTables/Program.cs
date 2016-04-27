using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeTables.NumberAlgorithms;

namespace PrimeTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*     Coding Exercise - Prime Tables     *");
            Console.WriteLine("******************************************\n");

            bool validInput = false;
            int numberOfPrimes;

            do
            {
                Console.WriteLine("Please enter the number of primes you require:");
                string input = Console.ReadLine();                

                if (Int32.TryParse(input, out numberOfPrimes) && numberOfPrimes>=1)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Number entered must be a whole number (no decimals) and must be at least 1.");
                }
            }
            while (!validInput);

            PrimeGenerator primeGenerator = GetPrimeGenerator(numberOfPrimes);
            int[] listOfPrimes = primeGenerator.Run();

            //Got the primes list, now produce the table:
            //First row
            Console.Write("\n|\t " + " ");
            for (int i = 0; i < listOfPrimes.Length; i++)
            {
                Console.Write("|\t" + listOfPrimes[i] + " ");
            }
            Console.Write("|"); 

            //Now do all remaining rows
            //For each row, loop through the prime list and perform multiplication as you go
            for(int i=0; i< listOfPrimes.Length; i++)
            {
                Console.Write("\n|\t" + listOfPrimes[i] + " ");
                for(int j=0; j< listOfPrimes.Length; j++)
                {
                    Console.Write("|\t" + listOfPrimes[i] * listOfPrimes[j] + " ");
                }

                Console.Write("|");
            }
            

            Console.WriteLine("\n\nPress any key to quit...");
            Console.ReadKey();
        }

        private static PrimeGenerator GetPrimeGenerator(int numberOfPrimes)
        {
            AlgorithmParameter<int> primesParam = new AlgorithmParameter<int>()
            {
                Value = numberOfPrimes
            };

            PrimeGenerator primeGenerator = new PrimeGenerator(primesParam);
            return primeGenerator;
        }
    }
}
