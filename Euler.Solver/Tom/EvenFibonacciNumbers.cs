﻿namespace Euler.Solver.Tom
{
    public class EvenFibonacciNumbers : ILongInputProblemSolver
    {
        public long SolveProblem(long input)
        {
            int previous = 0;
            int actual = 2;
            long result = 0;

            while (actual <= input)
            {
                result += actual;
                int tmp = actual;
                actual = actual * 4 + previous;
                previous = tmp;
            }

            return result;
        }
    }
}
