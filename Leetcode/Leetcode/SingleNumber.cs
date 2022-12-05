namespace Leetcode;

public class SingleNumber
{
    public int GetSingleNumber(int[] nums) => 
        nums.Aggregate(0, (current, n) => n ^ current);
}