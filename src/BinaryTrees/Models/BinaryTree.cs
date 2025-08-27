namespace BinaryTrees.Models;

public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value)
    {
        this.value = value;
        left = null;
        right = null;
    }

    public BinaryTree(int value, BinaryTree left, BinaryTree right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
}