namespace Euler.Solver.Tom
{
    public class LargeSum : IStringArrayInputProblemSolver
    {
        private const int ASCII_NUMBER = 48;

        public long SolveProblem(string[] input)
        {
            int lineLength = input[0].Length;
            int reminder = 0;

            string result = null;

            int asciiSubtractor = input.Length * ASCII_NUMBER;

            for (int i = lineLength - 1; i >= 0; i--)
            {
                int interResult = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    interResult += input[j][i];
                }

                interResult += reminder - asciiSubtractor;
                int lastDigit = interResult % 10;
                result = lastDigit + result;

                reminder = (interResult - lastDigit) / 10;
            }

            if (reminder != 0)
            {
                result = reminder + result;
            }

            var resultString = result;
            return long.Parse(resultString.Length > 10 ? resultString.Substring(0, 10) : resultString);
        }
    }
}
