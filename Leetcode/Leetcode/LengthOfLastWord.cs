namespace Leetcode;

public class LengthOfLastWord
{
    public static int GetLengthOfLastWord(string s)
    {
        var res = s.Trim().Split(' ').Last();

        return res.Length;
    }
}