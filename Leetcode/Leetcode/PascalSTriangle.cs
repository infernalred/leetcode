namespace Leetcode;

public static class PascalSTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var res = new List<IList<int>> {new List<int>{1}};

        for (int i = 1; i < numRows; i++)
        {
            var tmp = Enumerable.Repeat(1, res.Count + 1).ToArray();
            for (int j = 1; j < tmp.Length - 1; j++)
            {
                tmp[j] = res[^1][j - 1] + res[^1][j];
            }
            res.Add(tmp);
        }

        return res;
    }
}