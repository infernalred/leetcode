using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Test1()
    {
        const int input = 3;

        var expect = new [] {"1","2","Fizz"};

        var actual = FizzBuzz.FizzBuzzSolution(input);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test2()
    {
        const int input = 5;

        var expect = new [] {"1","2","Fizz","4","Buzz"};

        var actual = FizzBuzz.FizzBuzzSolution(input);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test3()
    {
        const int input = 15;

        var expect = new [] {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};

        var actual = FizzBuzz.FizzBuzzSolution(input);
        
        Assert.Equal(expect, actual);
    }
}