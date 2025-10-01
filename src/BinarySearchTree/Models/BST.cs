namespace BinarySearchTree.Models;

public class BST
{
    public int Value;
    public BST Left = null!;
    public BST Right = null!;

    public BST(int value)
    {
        this.Value = value;
    }

    public BST(int value, BST left, BST right)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }
}