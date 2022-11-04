namespace Leetcode;

public static class LongestCommonPrefix
{
    public static string GetLongestCommonPrefix(string[] strs)
    {
        var minWord = strs.FirstOrDefault();
        if (string.IsNullOrEmpty(minWord)) return string.Empty;
        var index = 0;
        for (int i = 0; i < minWord.Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != minWord[i])
                {
                    return minWord.Substring(0, index);
                }
            }

            index++;
        }

        return minWord.Substring(0, index);
    }
}