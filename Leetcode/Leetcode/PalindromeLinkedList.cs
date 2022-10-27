namespace Leetcode;

public class PalindromeLinkedList
{
    public bool IsPalindrome(ListNode? head)
    {
        if (head == null || head.next == null)
            return true;
        
        var hare = head;
        var tortoise = head;

        while (hare != null && hare.next != null)
        {
            hare = hare.next.next;
            tortoise = tortoise?.next;
        }

        ListNode previous = null;
        while (tortoise != null)
        {
            var tmp = tortoise.next;
            tortoise.next = previous;
            previous = tortoise;
            tortoise = tmp;
        }

        var left = head;
        var right = previous;
        while (right != null)
        {
            if (left.val != right.val)
            {
                return false;
            }

            left = left.next;
            right = right.next;
        }

        return true;
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}