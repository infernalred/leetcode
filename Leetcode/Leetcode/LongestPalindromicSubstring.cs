namespace Leetcode;

public static class LongestPalindromicSubstring
{
    public static string LongestPalindrome(string s)
    {
        var start = 0;
        var length = 0;

        for (int i = 0; i < s.Length; i++)
        {
            Find(s, i, i, ref start, ref length);
            
            Find(s, i, i + 1, ref start, ref length);
        }

        return s.Substring(start, length);
    }

    private static void Find(string s, int left, int right, ref int start, ref int length)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            if (right - left + 1 > length)
            {
                start = left;
                length = right - left + 1;
            }

            left--;
            right++;
        }
    }
}