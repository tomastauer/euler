using System;

namespace Euler.Solver.Tom
{
    public class SummationOfPrimes : ILongInputProblemSolver
    {
        private bool[] mPrimes;
        private int counter;
        private long l = 0;
        
        public long SolveProblem(long input)
        {
            if (input <= 2)
            {
                return 0;
            }

            l = input / 2 + 2;
            mPrimes = new bool[l];
            counter = 3;
            long result = 2;
            while (counter < l)
            {
               int prime = (int)(GetNextPrime() * 2) - 3;
               result += prime;
            }

            return result;
        }


        public double GetNextPrime()
        {
            while (counter < l)
            {
                if (!mPrimes[counter])
                {
                    for (int j = 0; counter + j * (counter *2 -3) < l; j++)
                    {
                        mPrimes[counter + j * (counter * 2 - 3)] = true;
                    }

                    int tmp = counter;
                    counter++;
                    return tmp;
                }
            
                counter++;
            }

            return 1.5;
        }
    }
}
