using System;
using System.Collections.Generic;

namespace Euler.Solver.Jirka
{
    public class SumSquareDifference : IScalarProblemSolver
    {
        public long SolveProblem(long input)
        {
            //return Optimized(input);
            return BruteForce(input);
        }

        private static long Optimized(long input)
        {
            long sumTotal = input*(input + 1)/2;
            long sumSquares = sumTotal;
            long previous = sumTotal;

            for (int i = 1; i < input; i++)
            {
                previous = previous - i;
                sumSquares += previous;
            }

            return sumTotal*sumTotal - sumSquares;
        }

        private static long BruteForce(long input)
        {
            long sumSquares = 0;
            long sumTotal = 0;
            for (long i = 1; i <= input; i++)
            {
                sumSquares += i*i;
                sumTotal += i;
            }

            return sumTotal*sumTotal - sumSquares;
        }
    }
}
