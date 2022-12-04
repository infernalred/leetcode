namespace Leetcode;

public class Sqrt
{
    public int MySqrt(int x)
    {
        long result = x;

        while (result * result > x)
        {
            result = (result + x / result) / 2;
        }

        return (int)result;
    }
}