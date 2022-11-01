namespace Leetcode;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        var left = 0;
        var right = 0;
        var result = 0;
        var dic = new Dictionary<char, bool>();
        while (right < s.Length)
        {
            if (!dic.ContainsKey(s[right]) || dic[s[right]] == false)
            {
                result = Math.Max(result, right - left + 1);
                dic[s[right]] = true;
                right++;
            }
            else
            {
                dic[s[left]] = false;
                left++;
            }
        }

        return result;
    }
}