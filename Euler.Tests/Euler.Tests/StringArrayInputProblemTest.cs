using System;
using System.Diagnostics;

using Euler.Solver;

using NUnit.Framework;

namespace Euler.Tests
{
    public class StringArrayInputProblemTest
    {
        private readonly IStringArrayInputProblemSolver mTomsSolver;
        private readonly IStringArrayInputProblemSolver mJirkasSolver;
        private const int mNumberOfRepetition = 10;


        public StringArrayInputProblemTest(IStringArrayInputProblemSolver tomsSolver, IStringArrayInputProblemSolver jirkasSolver)
        {
            mTomsSolver = tomsSolver;
            mJirkasSolver = jirkasSolver;
        }


        protected void CorrectnessBaseTom(string[] input, long expectedResult)
        {
            CheckCorrectness(mTomsSolver, input, expectedResult);
        }


        protected void CorrectnessBaseJirka(string[] input, long expectedResult)
        {
            CheckCorrectness(mJirkasSolver, input, expectedResult);
        }


        private void CheckCorrectness(IStringArrayInputProblemSolver solver, string[] input, long expectedResult)
        {
            var result = solver.SolveProblem(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }


        protected void PerformanceBaseTom(string[] input, int numberOfIterations)
        {
            for (int i = 0; i < mNumberOfRepetition; i++)
            {
                CheckPerformance(mTomsSolver, input, numberOfIterations);
            }
        }


        protected void PerformanceBaseJirka(string[] input, int numberOfIterations)
        {
            for (int i = 0; i < mNumberOfRepetition; i++)
            {
                CheckPerformance(mJirkasSolver, input, numberOfIterations);
            }
        }


        private static void CheckPerformance(IStringArrayInputProblemSolver solver, string[] input, int numberOfIterations)
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
