namespace Leetcode;

public class ReverseString
{
    public void ReverseStringMethod(char[] s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}