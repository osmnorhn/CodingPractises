#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Osman Orhan. All Rights Reserved. 
//------------------------------------------------------------------------
// Project: Answers
// Module : <module>
// File   : AddTwoNumbers
// Author : osmnorhn@gmail.com
// Date   : 10/12/2019 12:20:55 PM
//------------------------------------------------------------------------
#endregion

namespace Answers
{
    /// <summary>
    // Add Two Numbers
    // Difficulty: Medium
    // You are given two non-empty linked lists representing two non-negative integers.
    // The digits are stored in reverse order and each of their nodes contain a single digit. 
    // Add the two numbers and return it as a linked list.
    // You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    // Example:
    // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    // Output: 7 -> 0 -> 8
    // Explanation: 342 + 465 = 807
    /// </summary>
    public class AddTwoNumbersSolution
    {
        // ########################################################################################
        #region Nested Classes
        // Contains all non-public nested classes and locally scoped interface definitions

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        #endregion

        // ########################################################################################
        #region Public Methods
        // Contains all public methods of the class

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0);
            ListNode listNode1 = l1, listNode2 = l2, current = node;
            int carry = 0;
            while (listNode1 != null || listNode2 != null)
            {
                int val1 = listNode1?.val ?? 0;
                int val2 = listNode2?.val ?? 0;
                int sum = carry + val1 + val2;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if (listNode1 != null)
                {
                    listNode1 = listNode1.next;
                }

                if (listNode2 != null)
                {
                    listNode2 = listNode2.next;
                }
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return node.next;
        }

        #endregion

        // ########################################################################################
        #region Private Implementation
        // Contains the private implementation of the class

        #endregion
    }
}
