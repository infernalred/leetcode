namespace Leetcode;

public class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        return s.OrderBy(x => x).SequenceEqual(t.OrderBy(x => x));
    }
}