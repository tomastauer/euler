using System;
using System.Diagnostics;

using Euler.Solver;

using NUnit.Framework;

namespace Euler.Tests
{
    public class LongInputProblemTest
    {
        private readonly ILongInputProblemSolver mTomsSolver;
        private readonly ILongInputProblemSolver mJirkasSolver;
        private const int mNumberOfRepetition = 10;


        public LongInputProblemTest(ILongInputProblemSolver tomsSolver, ILongInputProblemSolver jirkasSolver)
        {
            mTomsSolver = tomsSolver;
            mJirkasSolver = jirkasSolver;
        }


        protected void CorrectnessBaseTom(long input, long expectedResult)
        {
            CheckCorrectness(mTomsSolver, input, expectedResult);
        }


        protected void CorrectnessBaseJirka(long input, long expectedResult)
        {
            CheckCorrectness(mJirkasSolver, input, expectedResult);
        }


        private void CheckCorrectness(ILongInputProblemSolver solver, long input, long expectedResult)
        {
            var result = solver.SolveProblem(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        

        protected void PerformanceBaseTom(long input, int numberOfIterations)
        {
            for (int i = 0; i < mNumberOfRepetition; i++)
            {
                CheckPerformance(mTomsSolver, input, numberOfIterations);
            }
        }


        protected void PerformanceBaseJirka(long input, int numberOfIterations)
        {
            for (int i = 0; i < mNumberOfRepetition; i++)
            {
                CheckPerformance(mJirkasSolver, input, numberOfIterations);
            }
        }


        private static void CheckPerformance(ILongInputProblemSolver solver, long input, int numberOfIterations)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numberOfIterations; i++)
            {
                solver.SolveProblem(input);
            }

            stopwatch.Stop();

            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
        }
    }
}
