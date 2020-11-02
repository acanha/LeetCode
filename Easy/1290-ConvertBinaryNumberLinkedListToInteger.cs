using System;
using System.Collections.Generic;
using System.Text;

/*
    Given head which is a reference node to a singly-linked list. 
    The value of each node in the linked list is either 0 or 1. 
    The linked list holds the binary representation of a number.

    Return the decimal value of the number in the linked list.
 */

public class Problem1290
{
    public int Solution(ListNode head)
    {
        var number = GenerateBinary(head);

        return Convert.ToInt32(number, 2);
    }

    private string GenerateBinary(ListNode node)
        => $"{node.val}{(node.next != null ? GenerateBinary(node.next) : string.Empty)}";
    
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

