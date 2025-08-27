using BinaryTrees.Models;

namespace BinaryTrees.Easy;

public static class NodeDepth
{
    public static int GetNodeDepth(BinaryTree root)
    {
        return CalculateDepth(root, 0);
    }

    private static int CalculateDepth(BinaryTree node, int depth)
    {
        if (node == null)
        {
            return 0;
        }

        return depth + CalculateDepth(node.left, depth + 1) + CalculateDepth(node.right, depth + 1);
    }
}