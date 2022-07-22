public class Solution
{
    static void Main()
    {
        Solution solution = new Solution();
        ListNode list1 = new ListNode(2);
        ListNode list2 = new ListNode(1);
        Console.WriteLine(solution.MergeTwoLists(list1, list2));
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode result = list1;
        ListNode supportiveList1 = list1;
        ListNode nonChangeableList1 = list1;
        ListNode externalСycleValue = list1;
        ListNode internalСycleValue = list1;

        while (supportiveList1.next != null)
        {
            supportiveList1 = supportiveList1.next;
        }
        supportiveList1.next = list2; // link lists

        while (externalСycleValue != null)
        {
            while (internalСycleValue != null)
            {
                if (internalСycleValue.val > externalСycleValue.val)
                {
                    int tmp = externalСycleValue.val;
                    externalСycleValue.val = internalСycleValue.val;
                    internalСycleValue.val = tmp;
                }
                internalСycleValue = internalСycleValue.next;
            }
            externalСycleValue = externalСycleValue.next;
            internalСycleValue = nonChangeableList1;
        }
        return result;
    }
}