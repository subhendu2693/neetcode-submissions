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
    public ListNode ReverseList(ListNode head) {
        ListNode prev;ListNode p;ListNode next;
        prev=null;p=head;
        while(p!=null)
        {
            next=p.next;
            p.next=prev;
            prev=p;
            p=next;
        }
        head=prev;
        return head;
    }
}
