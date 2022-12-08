namespace Leetcode;

public static class MajorityElement
{
    public static int GetMajorityElement(int[] nums)
    {
        var r = 0;
        var c = 0;

        foreach (var num in nums)
        {
            if (c == 0)
                r = num;

            c += num == r ? 1 : -1;
        }

        return r;
    }
}