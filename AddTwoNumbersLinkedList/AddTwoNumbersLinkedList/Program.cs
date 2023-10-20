Solution ob = new();
ListNode l1 = new();
ListNode l2 = new();
l1.val = 9;
l1.next = new(9);
l1.next.next = new(9);
l1.next.next.next = new(9);
l1.next.next.next.next = new(9);
l2.val = 9;
l2.next = new(9);
l2.next.next = new(9);
var an = ob.AddTwoNumbers(l1, l2);
Console.WriteLine(an.val + " " + an.next.val + " " + an.next.next.val + " " +
    an.next.next.next.val + " " + an.next.next.next.next.val + " " + an.next.next.next.next.next.val);


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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sum = l1.val + l2.val;
        int modul = sum / 10;
        ListNode l3 = new ListNode(sum % 10);
        var node3 = l3;

        l1 = l1.next;
        l2 = l2.next;
        while (l1 != null || l2 != null)
        {
            if (l1 == null)
                l1 = new ListNode(0);

            else if (l2 == null)
                l2 = new ListNode(0);
            sum = modul + l1.val + l2.val;
            node3.next = new ListNode(sum % 10);
            node3 = node3.next;
            modul = sum / 10;
            l1 = l1.next;
            l2 = l2.next;
        }
        if (modul == 1)
            node3.next = new(1);
        return l3;
    }
}