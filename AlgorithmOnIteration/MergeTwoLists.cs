﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmOnIteration
{
    class MergeTwoLists
    {
        public ListNode MergeTwoListsMethod(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;
            if(list2.val > list1.val)
            {
                list1.next = MergeTwoListsMethod(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoListsMethod(list1, list2.next);
                return list2;
            }
        }
    }
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
}
