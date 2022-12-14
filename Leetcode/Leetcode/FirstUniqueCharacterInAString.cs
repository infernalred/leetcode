namespace Leetcode;

public class FirstUniqueCharacterInAString
{
    public int FirstUniqChar(string s)
    {
        foreach (var letter in s.Distinct())
        {
            if (s.Count(x => x == letter) == 1)
            {
                return s.IndexOf(letter);
            }
        }
        return -1;
    }
}