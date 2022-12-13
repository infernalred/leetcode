using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class PascalsTriangleTests
{
    [Fact]
    public void Test1()
    {
        var actual = PascalSTriangle.Generate(5);

        var expected = new List<List<int>>
        {
            new()
            {
                1
            },
            new()
            {
                1,1
            },
            new()
            {
                1,2,1
            },
            new()
            {
                1,3,3,1
            },
            new()
            {
                1,4,6,4,1
            },
        };

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var actual = PascalSTriangle.Generate(1);

        var expected = new List<List<int>>
        {
            new()
            {
                1
            }
        };

        Assert.Equal(expected, actual);
    }
}