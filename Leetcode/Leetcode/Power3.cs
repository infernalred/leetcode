namespace Leetcode;

public class Power3
{
    public bool IsPowerOfThree(int n)
    {
        return n > 0 && 1162261467 % n == 0;
    }
}