namespace Leetcode;

public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        var table = new HashSet<char>
        {
            '(', '[', '{'
        };
        var valid = new Dictionary<char, char>
        {
            {'(', ')' },
            {')', '(' },
            {'[', ']' },
            {']', '[' },
            {'{', '}' },
            {'}', '{' }
        };
        
        var stack = new Stack<char>();

        foreach (var t in s)
        {
            if (table.Contains(t))
            {
                stack.Push(t);
            }
            else
            {
                stack.TryPop(out var letter);
                if (letter != valid[t])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}