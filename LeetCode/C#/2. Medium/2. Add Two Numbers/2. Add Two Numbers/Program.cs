

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
    static void Main()
    {
        Solution solution = new Solution();
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(9, null)));
        Console.WriteLine(solution.AddTwoNumbers(l1, l2));
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode current = new ListNode();
        int currentL1;
        int currentL2;
        int additionalDigit = 0;
        bool isList1End = false;
        bool isList2End = false;
        int digitCounter = 0;
        while (true)
        {
            additionalDigit = 0;

            if (isList1End)
                currentL1 = 0;
            else 
                currentL1 = l1.val;

            if (isList2End)
                currentL2 = 0;
            else
                currentL2 = l2.val;


            if (l1.next == null)
                isList1End = true;
            else l1 = l1.next;
            if (l2.next == null)
                isList2End = true;
            else l2 = l2.next;

            if (currentL1 + currentL2 + current.val > 9)
                additionalDigit = 1;

            current.val = current.val + currentL1 + currentL2 - additionalDigit * 10;
            if (result.next == null)
            {
                result = current;
            }
            if (isList1End && isList2End)
            {
                if (additionalDigit == 1)
                {
                    current.next = new ListNode(additionalDigit);
                }
                return result;
            }
            else
                current.next = new ListNode(additionalDigit);
            
            current = current.next;
            
        }
        
    }
}