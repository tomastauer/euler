namespace Euler.Solver.Tom
{
    public class MultipleOf3And5 : IScalarProblemSolver
    {
        public long SolveProblem(long input)
        {
            long three = (input - 1) / 3;
            long five = (input - 1) / 5;

            long result = 3L * (three + 1) * three >> 1;
            result += 5L * (five + 1) * five >> 1;

            long toBeSubtracted = five / 3;
            if (toBeSubtracted > 0)
            {
                result -= 15 * (toBeSubtracted + 1) * toBeSubtracted >> 1;
            }

            return result;
        }
    }
}
