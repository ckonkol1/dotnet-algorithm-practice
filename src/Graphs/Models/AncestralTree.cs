namespace Graph.Models;

public class AncestralTree(char name, AncestralTree? ancestor)
{
    public char Name = name;
    public AncestralTree Ancestor = ancestor!;
}