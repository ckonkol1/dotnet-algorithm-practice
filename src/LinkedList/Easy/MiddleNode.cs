namespace LinkedList.Easy;

/*
 *Middle Node
   You're given a Linked List with at least one node. Write a function that returns the middle node of the Linked List. If there are two middle
   nodes (i.e. an even length list), your function should return the second of these nodes.
   Each LinkedList node has an integer value as well asa next node pointing t othe next node in the list orto None / null if it's the tail of the list.

   Sample Input and Output:

        head = 0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6
         output = 3 -> 4 -> 5 -> 6

         head = 0 -> 1 -> 2 -> 3 -> 4 -> 5
         output = 3 -> 4 -> 5

    Space and Time Complexity: O(n) time | O(1) space
 */
public static class MiddleNode
{
    public static LinkedList GetMiddleNode(LinkedList linkedList)
    {
        var length = 0;
        var currentNode = linkedList;
        while (currentNode != null)
        {
            length++;
            currentNode = currentNode.Next;
        }

        var middle = length / 2;
        var count = 0;
        var middleNode = linkedList;
        while (count != middle)
        {
            count++;
            middleNode = middleNode.Next;
        }

        return middleNode;
    }

    public static LinkedList GetMiddleNodeSlowAndFastPointers(LinkedList linkedList)
    {
        var fastNode = linkedList;
        var slowNode = linkedList;

        while (fastNode != null && fastNode.Next != null)
        {
            slowNode = slowNode.Next;
            fastNode = fastNode.Next.Next;
        }

        return slowNode;
    }
}