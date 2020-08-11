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
//  input
//  [1,2,3,4,5]
// Output
// [5,4,3,2,1]
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
            return head;
        ListNode previous = null;
        var current = head;
        while (current != null) {
            var temp = current.next;
            current.next = previous;
            previous = current;
            current = temp;
        }

        return previous;
    }
    
}