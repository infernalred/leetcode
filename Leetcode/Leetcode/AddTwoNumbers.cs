using Leetcode.Models;

namespace Leetcode;

public class AddTwoNumbers
{
    public ListNode Result(ListNode l1, ListNode l2)
    {
        var st1 = new Stack<int>();
        var st2 = new Stack<int>();

        while (l1 != null)
        {
            st1.Push(l1.val);
            l1 = l1.next;
        }

        while (l2 != null)
        {
            st2.Push(l2.val);
            l2 = l2.next;
        }

        var number1 = string.Join("", st1);
        var number2 = string.Join("", st2);
        var number = Add(number1, number2);
        //var number = decimal.Parse(number1) + decimal.Parse(number2);
        //var numStr = $"{number:F0}";
        var result = new Queue<char>(number);
        var next = new ListNode(int.Parse(result.Dequeue().ToString()));
        while (result.Count > 0)
        {
            var node = new ListNode(int.Parse(result.Dequeue().ToString()), next);
            next = node;
        }

        return next;
    }
    
    string Add(string s1, string s2)
    {
        bool carry = false;
        string result = string.Empty;

        if (s1.Length < s2.Length)
            s1 = s1.PadLeft(s2.Length, '0');
        if(s2.Length < s1.Length)
            s2 = s2.PadLeft(s1.Length, '0');

        for(int i = s1.Length-1; i >= 0; i--)
        {
            var augend = Convert.ToInt64(s1.Substring(i,1));
            var addend = Convert.ToInt64(s2.Substring(i,1));
            var sum = augend + addend;
            sum += (carry ? 1 : 0);
            carry = false;
            if(sum > 9)
            {
                carry = true;
                sum -= 10;
            }
            result = sum.ToString() + result;
        }
        if(carry)
        {
            result = "1" + result;
        }

        return result;
    }
}

