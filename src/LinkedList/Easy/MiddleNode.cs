namespace LinkedList.Easy;

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