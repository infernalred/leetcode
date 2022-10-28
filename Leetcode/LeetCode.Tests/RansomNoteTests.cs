using Leetcode;
using Xunit;

namespace LeetCode.Tests;

public class RansomNoteTests
{
    [Fact]
    public void Test1()
    {
        const string ransomNote = "a"; 
        const string magazine = "b";

        const bool expect = false;

        var actual = RansomNote.CanConstruct(ransomNote, magazine);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test2()
    {
        const string ransomNote = "aa"; 
        const string magazine = "ab";

        const bool expect = false;

        var actual = RansomNote.CanConstruct(ransomNote, magazine);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test3()
    {
        const string ransomNote = "aa"; 
        const string magazine = "aab";

        const bool expect = true;

        var actual = RansomNote.CanConstruct(ransomNote, magazine);
        
        Assert.Equal(expect, actual);
    }
    
    [Fact]
    public void Test4()
    {
        const string ransomNote = "aab"; 
        const string magazine = "baa";

        const bool expect = true;

        var actual = RansomNote.CanConstruct(ransomNote, magazine);
        
        Assert.Equal(expect, actual);
    }
}