using BinarySearchTree.Models;

namespace BinarySearchTree.Easy;

public static class ClosestValue
{
    /*
     * Find Closest Value In BST
       Write a function that takes in a Binary Search Tree (BST) and a target integer Value and returns the closest Value to that target Value
       contained in the BST.
       You can assume that there will only be one closest Value.
       Each BST node has an integer Value , a Left child node, anda Right child node. A node is said to be a valid BST node if and
       only if it satisfies the BST property: its Value is strictly greater than the values of every node to its Left; its Value is less than or equal
       to the values of every node to its Right; and its children nodes are either valid BST nodes themselves or None / null

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
            var diff = Math.Abs(tree.Value - target);
            if (diff < Math.Abs(closestValue - target))
            {
                closestValue = tree.Value;
            }

            if (tree.Value == target)
            {
                closestValue = tree.Value;
                break;
            }
            else if (tree.Value < target)
            {
                tree = tree.Right;
            }
            else
            {
                tree = tree.Left;
            }
        }

        return closestValue;
    }
}