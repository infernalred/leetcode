namespace Leetcode;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var start = 0;
        var end = s.Length - 1;

        while (start < end)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
            }
            else if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
            }
            else
            {
                if (char.ToLower(s[start]) != char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }
            
        }

        return true;
    }
}