using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class NumberOfStepsToReduceANumberToZeroTests
{
    [Fact]
    public void Test1()
    {
        const int input = 14;

        const int expect = 6;

        var actual = NumberOfStepsToReduceANumberToZero.NumberOfSteps(input);
        
        Assert.Equal(expect, actual);
    }
}