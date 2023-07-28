/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
            int x = 0;
            int y = 0;
            int carry = 0;
            int resultValue = 0;

            ListNode l3 = new ListNode(0);
            ListNode head = l3;
            ListNode first = l1;
            ListNode second = l2;

            while (first != null || second != null)
            {
                x = (first != null) ? first.val : 0;
                y = (second != null) ? second.val : 0;
                resultValue = x + y + carry;
                carry = resultValue/10;

                l3.next = new ListNode(resultValue % 10);
                l3 = l3.next;
                
                if(first != null ) first = first.next;
                if(second != null ) second = second.next;
            }

            if(carry > 0)
            {
                l3.next = new ListNode(carry);
            }
            return head.next;
    }
}