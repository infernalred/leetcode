using Leetcode;
using Leetcode.Models;
using Xunit;

namespace LeetCode.Tests;

public class AddTwoNumbersTest
{
    [Fact]
    public void Test1()
    {
        var third1 = new ListNode(3);
        var second1 = new ListNode(4, third1);
        var first1 = new ListNode(2, second1);
        
        var third2 = new ListNode(4);
        var second2 = new ListNode(6, third2);
        var first2 = new ListNode(5, second2);

        var service = new AddTwoNumbers();
        var actual = service.Result(first1, first2);
        
        Assert.Equal(7, actual.val);
        Assert.Equal(0, actual.next.val);
    }
    
    [Fact]
    public void Test2()
    {
        var first1 = new ListNode(9);
        
        var next9 = new ListNode(9);
        var next8 = new ListNode(9, next9);
        var next7 = new ListNode(9, next8);
        var next6 = new ListNode(9, next7);
        var next5 = new ListNode(9, next6);
        var next4 = new ListNode(9, next5);
        var next3 = new ListNode(9, next4);
        var next2 = new ListNode(9, next3);
        var next1 = new ListNode(9, next2);
        var head = new ListNode(1, next1);

        var service = new AddTwoNumbers();
        var actual = service.Result(first1, head);
        
        Assert.Equal(7, actual.val);
        Assert.Equal(0, actual.next.val);
    }
    
    [Fact]
    public void Test3()
    {
        var next19 = new ListNode(9);
        var next18 = new ListNode(9, next19);
        var next17 = new ListNode(9, next18);
        var next16 = new ListNode(9, next17);
        var next15 = new ListNode(9, next16);
        var next14 = new ListNode(9, next15);
        var next13 = new ListNode(9, next14);
        
        var next9 = new ListNode(9);
        var next8 = new ListNode(9, next9);
        var next7 = new ListNode(9, next8);
        var next6 = new ListNode(9, next7);

        var service = new AddTwoNumbers();
        var actual = service.Result(next13, next6);
        
        Assert.Equal(7, actual.val);
        Assert.Equal(0, actual.next.val);
    }
    
    [Fact]
    public void Test4()
    {
        var first1 = new ListNode(9);
        
        var next9 = new ListNode(9);
        var next8 = new ListNode(9, next9);
        var next7 = new ListNode(9, next8);
        var next6 = new ListNode(8, next7);
        var next5 = new ListNode(9, next6);
        var next4 = new ListNode(9, next5);
        var next3 = new ListNode(9, next4);
        var next2 = new ListNode(9, next3);
        var next1 = new ListNode(9, next2);
        var head = new ListNode(1, next1);

        var service = new AddTwoNumbers();
        var actual = service.Result(first1, head);
        
        Assert.Equal(7, actual.val);
        Assert.Equal(0, actual.next.val);
    }
}