using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class TheKWeakestRowsInAMatrixTest
{
    [Fact]
    public void Test1()
    {
        var mat = new []
        {
            new []{1,1,0,0,0},
            new []{1,1,1,1,0},
            new []{1,0,0,0,0},
            new []{1,1,0,0,0},
            new []{1,1,1,1,1}
        }; 
        const int k = 3;

        var expect = new []{2,0,3};

        var actual = TheKWeakestRowsInAMatrix.KWeakestRows(mat, k);
        
        Assert.Equal(expect, actual);
    }
}