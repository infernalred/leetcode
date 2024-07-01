namespace Leetcode;

public class IsPalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        var j = 0;
        var k = x;

        while (k > 0)
        {
            j = j * 10 + k % 10;
            k /= 10;
        }

        return j == x;
    }
}