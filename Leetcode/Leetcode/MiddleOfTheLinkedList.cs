using Leetcode.Models;

namespace Leetcode;

public class MiddleOfTheLinkedList
{
    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}