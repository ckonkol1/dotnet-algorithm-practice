using BinarySearchTree.Models;

namespace BinarySearchTree.Easy;

public static class ClosestValue
{
    /*
     * Find Closest Value In BST
       Write a function that takes in a Binary Search Tree (BST) and a target integer value and returns the closest value to that target value
       contained in the BST.
       You can assume that there will only be one closest value.
       Each BST node has an integer value , a left child node, anda right child node. A node is said to be a valid BST node if and
       only if it satisfies the BST property: its value is strictly greater than the values of every node to its left; its value is less than or equal
       to the values of every node to its right; and its children nodes are either valid BST nodes themselves or None / null

        Sample Input: tree =    10
                              /   \
                            5      15
                          /  \    /   \
                         2    5  13    22
                       /          \
                      1            14
                    target = 12
       Sample Output: 13
     */
    public static int FindClosestValueInBst(BST tree, int target)
    {
        var closestValue = int.MaxValue - 1;

        while (tree != null)
        {
            var diff = Math.Abs(tree.value - target);
            if (diff < Math.Abs(closestValue - target))
            {
                closestValue = tree.value;
            }

            if (tree.value == target)
            {
                closestValue = tree.value;
                break;
            }
            else if (tree.value < target)
            {
                tree = tree.right;
            }
            else
            {
                tree = tree.left;
            }
        }

        return closestValue;
    }
}