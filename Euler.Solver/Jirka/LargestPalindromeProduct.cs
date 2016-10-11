using System.Linq;

namespace Euler.Solver.Jirka
{
    public class LargestPalindromeProduct : ILongInputProblemSolver
    {
        private long mInput;
        private int[] mPalindrom;

        public long SolveProblem(long input)
        {
            if (input == 1)
            {
                return 9;
            }

            mInput = input;
            int[] pole = new int[input*2];
            for (int i = 0; i < input*2; i++)
            {
                pole[i] = 9;
            }
            mPalindrom = pole;

            int maxNumber = 1;
            int maxDelitel = 0;
            for (int i = 0; i < input; i++)
            {
                maxDelitel += maxNumber * 9;
                maxNumber *= 10;
            }


            long result = 0;
            for (int i = 0; i < mPalindrom.Length; i++)
            {
                result += mPalindrom[i] * Power(i);
            }

            long nextPalindrom = result;
            while(true)
            {
                for (int j = maxDelitel; j > 0; j--)
                {
                    if (nextPalindrom / j < maxNumber)
                    {
                        if (nextPalindrom % j == 0)
                        {
                            return nextPalindrom;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                nextPalindrom = GetLowerPalindrom();
            }
        }

        #region Bruteforce

        public long BruteForce(long input)
        {
            int maxNumber = 1;
            int maxDelitel = 0;
            for (int i = 0; i < input; i++)
            {
                maxDelitel += maxNumber * 9;
                maxNumber *= 10;
            }
            long maxPalindrom = (long)maxDelitel*maxNumber + maxDelitel;

            for (long i = maxPalindrom; i > 0; i--)
            {
                if (IsPalindrom(i))
                {
                    for (int j = maxDelitel; j > 0; j--)
                    {
                        if (i/j < maxNumber)
                        {
                            if (i%j == 0)
                            {
                                return i;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            
            return 0;
        }


        public bool IsPalindrom(long input)
        {
            if (input < 10)
            {
                return true;
            }
            
            string original = input.ToString();
            string reversed = new string(original.Reverse().ToArray());

            return original == reversed;
        }

        #endregion

        public long GetLowerPalindrom()
        {
            PerformMagic(mInput);
            long result = 0;
            for (int i = 0; i < mPalindrom.Length; i++)
            {
                result += mPalindrom[i]* Power(i);
            }

            return result;
        }


        private void PerformMagic(long position)
        {
            if (mPalindrom[position - 1] != 0)
            {
                mPalindrom[position - 1] -= 1;
                mPalindrom[mPalindrom.Length - position] -= 1;
            }
            else
            {
                mPalindrom[position - 1] = 9;
                mPalindrom[mPalindrom.Length - position] = 9;
                if(position > 1) PerformMagic(position-1);
            }
        }


        private long Power(int number)
        {
            long result = 1;
            for (int i = 0; i < number; i++)
            {
                result *= 10;
            }

            return result;
        }
    }
}
