using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class MedianOfTwoSortedArraysTests
{
    [Fact]
    public void Test1()
    {
        var nums1 = new int[]{1, 3};
        var nums2 = new int[]{2};
        
        var actual = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        
        Assert.Equal(2.00000, actual);
    }
    
    [Fact]
    public void Test2()
    {
        var nums1 = new int[]{1, 2};
        var nums2 = new int[]{3, 4};
        
        var actual = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        
        Assert.Equal(2.50000, actual);
    }
}