using System.Collections.Generic;

namespace Euler.Solver.Jirka
{
    public class PrimeFactors : ILongInputProblemSolver
    {
        public long SolveProblem(long input)
        {
            return BruteForce(input);
        }

        private long BruteForce(long input)
        {
            while (true)
            {
                if (input%2 == 0)
                {
                    input = input/2;
                    if (input == 1)
                    {
                        return 2;
                    }
                }
                else
                {
                    break;
                }
            }


            int number = 3;
            while (true)
            {
                if (input%number == 0)
                {
                    input = input/number;
                    if (input == 1)
                    {
                        break;
                    }
                }
                else
                {
                    number += 2;
                }
            }

            return number;
        }
    }
}
