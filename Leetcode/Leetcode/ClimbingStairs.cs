﻿namespace Leetcode;

public static class ClimbingStairs
{
    public static int ClimbStairs(int n)
    {
        var one = 1;
        var two = 1;

        for (var i = 0; i < n - 1; i++)
        {
            var temp = one;
            one += two;
            two = temp;
        }

        return one;
    }
}