namespace Leetcode;

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        var fast = head?.next;
        var slow = head;

        while (fast?.next != null)
        {
            if (fast == slow)
            {
                return true;
            }

            slow = slow?.next;
            fast = fast.next.next;
        }

        return false;
    }
}