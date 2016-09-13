using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.Solver.Tom
{
    public class PrimeFactors : IScalarProblemSolver
    {
        private bool[] mPrimes;
        private int l = 6900;
        private int counter;

        public long SolveProblem(long input)
        {
            mPrimes = new bool[l];
            counter = 2;
            long tmp = input;

            while (true)
            {
                var currentPrime = GetNextPrime();
                while (tmp % currentPrime == 0)
                {
                    tmp /= currentPrime;
                }
                
                if (tmp == 1)
                {
                    return currentPrime;
                }
            }
        }

        public int GetNextPrime()
        {
            while (true)
            {
                if (!mPrimes[counter])
                {
                    for (int j = 1; j * counter < l; j++)
                    {
                        mPrimes[j * counter] = true;
                    }
                    return counter++;
                }

                counter++;
            }
        }
    }
}
