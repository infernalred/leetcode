namespace Leetcode;

public static class TwoSumTask
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var visited = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (visited.ContainsKey(target - nums[i]))
            {
                return new[] {visited[target - nums[i]], i};
            }

            visited[nums[i]] = i;
        }

        return new int[2];
    }
}