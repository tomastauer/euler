using System;
using System.Diagnostics;

namespace Euler.Solver.Tom
{
    public class SumSquareDifference : IScalarProblemSolver
    {
        public long SolveProblem(long input)
        {
            long sum = (1 + input) * input >> 1;
            long squareOfSum = sum * sum;

            long sumOfSquares = 0;
            for (int i = 1; i <= input; i++)
            {
                //sumOfSquares += (input - i) * (1 + 2 * i);

                sumOfSquares += i * i;
            }
            return squareOfSum - sumOfSquares;
        }


//        public long Add(long input)
//        {
//            if (input == 4 || input == 5)
//            {
//                return 2;
//            }

//            var i = (input - 8) >> 1;
//            var z = ((i + 1) * i) >> 1;

//Console.WriteLine(z);
//            return 10 + ((input - 6) >> 1) * 18 + z * 10;
            

//            return 0;
//        }


//        private void Foo(long input)
//        {
//            long min = 1;
//            if (input % 2 == 0)
//            {
//                long max = 1 + (2 * input >> 1);

//                long sum = (min + max) * input >> 1;

//            }

//        }
    }
}
