namespace Leetcode;

public static class TheKWeakestRowsInAMatrix
{
    public static int[] KWeakestRows(int[][] mat, int k)
    {
        //old
        // var dic = new Dictionary<int, int>();
        // for (int i = 0; i < mat.Length; i++)
        // {
        //     var row = mat[i].Sum();
        //     dic.Add(i, row);
        // }
        // var dicNew = dic.OrderBy(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        // return dicNew;
        
        //after refactor

        return mat
            .Select((x, y) => (y, cnt: x.Sum()))
            .OrderBy(x => x.cnt)
            .Select(x => x.y)
            .Take(k)
            .ToArray();
    }
}