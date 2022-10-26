namespace Leetcode;

public static class FizzBuzz
{
    public static IList<string> FizzBuzzSolution(int n)
    {
        var result = new List<string>(n);
        
        for (int i = 1; i <= n; i++)
        {
            var fizz = i % 3 == 0;
            var buzz = i % 5 == 0;
            
            if (fizz && buzz)
            {
                result.Add("FizzBuzz");
            } else if (fizz)
            {
                result.Add("Fizz");
            } else if (buzz)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }

        return result;
    }
}