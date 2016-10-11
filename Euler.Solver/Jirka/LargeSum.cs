using System;
using System.Numerics;

namespace Euler.Solver.Jirka
{
    public class LargeSum : IStringArrayInputProblemSolver
    {
        public long SolveProblem(string[] input)
        {
            BigInteger result = 0;
            foreach (string number in input)
            {
                result += BigInteger.Parse(number);
            }

            string resultString = result.ToString();
            return Convert.ToInt64(resultString.Length >= 10 ? resultString.Substring(0, 10) : resultString);
        }
    }
}