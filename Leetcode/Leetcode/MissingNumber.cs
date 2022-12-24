namespace Leetcode;

public static class MissingNumber
{
    public static int GetMissingNumber(int[] nums)
    {
        return nums.Length + nums.Select((t, i) => i - t).Sum();
    }
}