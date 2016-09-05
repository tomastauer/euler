namespace Euler.Solver.Jirka
{
    public class EvenFibonacciNumbers : IScalarProblemSolver
    {
        public long SolveProblem(int input)
        {
            return UseBrain2(input);
        }


        /// <summary>
        /// Only every 3rd member can be even (must be the sum of odd numbers).
        /// 1, 2, 3, 5, 8, 13, 21, 34
        /// -, |, -, -, |,  -,  -,  |
        /// When we compute always 2 members in one loop we can see only 1st and 3rd loop contains odd numbers.
        /// </summary>
        public long UseBrain(int maxMemberValue)
        {
            uint a = 1, b = 2;

            long result = 0;
            byte temp = 0;

            while (true)
            {
                if (temp == 0)
                {
                    result += b;
                    temp++;
                }
                else if (temp == 1)
                {
                    temp++;
                }
                else
                {
                    result += a;
                    temp = 0;
                }

                a += b;
                b += a;

                // b is always higher
                if (b > maxMemberValue) break;
            }

            return result;
        } // 0.235 + doesn't pass the test (10,10)


        /// <summary>
        /// Only every 3rd member can be even (must be the sum of odd numbers).
        /// 1, 2, 3, 5, 8, 13, 21, 34
        /// -, |, -, -, |,  -,  -,  |
        /// When we compute always 2 members in one loop we can see only 1st and 3rd loop contains odd numbers.
        /// This method gets rid of the temp variable.
        /// </summary>
        public long UseBrain2(int maxMemberValue)
        {
            int a = 1, b = 2;
            long result = 0;

            while (true)
            {
                // ---- LOOP 1
                result += b;

                a += b;
                b += a;

                if (b > maxMemberValue) break;

                // ---- LOOP 2
                a += b;
                b += a;

                if (b > maxMemberValue)
                {
                    if (a <= maxMemberValue)
                    {
                        result += a;
                    }
                    break;
                }; // check here because the 'a' can be even

                // ---- LOOP 3
                result += a;

                a += b;
                b += a;

                if (b > maxMemberValue) break;
            }

            return result;
        } // 0.104
    }
}
