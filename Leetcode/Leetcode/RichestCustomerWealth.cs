namespace Leetcode;

public class RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        return accounts
            .Select(x => x.Sum())
            .Max();
    }
}