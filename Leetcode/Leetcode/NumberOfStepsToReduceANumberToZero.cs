namespace Leetcode;

public static class NumberOfStepsToReduceANumberToZero
{
    public static int NumberOfSteps(int num)
    {
        var result = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                --num;
            }

            ++result;
        }
        return result;
    }
}