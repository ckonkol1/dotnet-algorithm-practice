/*
 *Remove Duplicates From Linked List
   You're given the head of a Singly Linked List whose nodes are in sorted order with respect to their values. Write a function that returns a
   modified version of the Linked List that doesn't contain any nodes with duplicate values. The Linked List should be modified in place
   (i.e., you shouldnt create a brand new list), and the modified Linked List should still have its nodes sorted with respect to their values.
   Each LinkedList node has an integer value aswell asa next node pointing tothe next node in the list or to None / null if
   it's the tail of the list.

    Sample Input:
        head = 2 -> 2 -> 2 -> 3 -> 4 -> 4 -> 5 -> 5 -> 5
    Sample Output: 2 -> 3 -> 4 -> 5
 */

namespace LinkedList.Easy;

public static class RemoveDuplicates
{
    //O(n) time | O(1) space
    public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
    {
        var currentNode = linkedList;
        while (currentNode != null)
        {
            var nextNode = currentNode.Next;
            while (nextNode != null! && nextNode.Value == currentNode.Value)
            {
                nextNode = nextNode.Next;
            }

            currentNode.Next = nextNode!;
            currentNode = nextNode;
        }

        return linkedList;
    }
}