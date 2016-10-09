using System;

namespace Euler.Solver.Tom
{
    public class LargestPalindromeProduct : ILongInputProblemSolver
    {
        public long SolveProblem(long input)
        {
            if (input % 2 == 0)
            {
                return GetResultForEvenInput(input);
            }

            if (input == 1)
            {
                return 9;
            }

            int maxNumber = (int)Math.Pow(10, input) - 1;
            int minNumber = maxNumber - ((int) Math.Pow(10, (input+1) >> 1) - 1);

            for (int i = maxNumber; i >= minNumber; i = Decrease(i))
            {
                for (int j = i; j >= minNumber; j = Decrease(j))
                {
                    long result = (long)i * (long)j;
                    string sResult = result.ToString();
                    if (IsPalindrome(sResult))
                    {
                        return result;
                    }
                }
            }

           throw new Exception();
        }


        private long GetResultForEvenInput(long input)
        {
            long firstMultiplier = (long)Math.Pow(10, input) - 1;
            long secondMultiplier = firstMultiplier - ((long) Math.Pow(10, input >> 1) - 2);

            return firstMultiplier * secondMultiplier;
        }


        private int Decrease(int n)
        {
            int lastDigit = n % 10;
            if (lastDigit == 9)
            {
                return n - 6;
            }

            if (lastDigit == 3 || lastDigit == 1)
            {
                return n - 2;
            }

            throw new Exception();
        }


        private bool IsPalindrome(string input)
        {
            return Reverse(input) == input;
        }

        
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
