
 

Console.WriteLine(value: new Solution().DeleteDuplicates(new ListNode(0)));
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return head;
        if (head.next == null)
            return head;
        ListNode previousValue = head;
        ListNode current = head.next;
        do
        {
            if (current.val == previousValue.val)
            {
                previousValue.next = null;
                current = current.next;
                continue;
            }
            else
            {
                if(previousValue.next == null)
                    previousValue.next = current;
                previousValue = previousValue.next;
                current = current.next;
            }
        } while (current != null);
        return head;
    }
}