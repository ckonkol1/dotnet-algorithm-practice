using Graph.Models;

namespace Graph.Medium;

public class YoungestCommonAncestor
{
    public static AncestralTree GetYoungestCommonAncestor(
        AncestralTree topAncestor,
        AncestralTree descendantOne,
        AncestralTree descendantTwo
    )
    {
        //Get descendant Depth
        var depth1 = GetDescendantDepth(descendantOne);
        var depth2 = GetDescendantDepth(descendantTwo);

        return depth1 < depth2
            ? GetCommonAncestor(descendantTwo, descendantOne, depth2 - depth1)
            : GetCommonAncestor(descendantOne, descendantTwo, depth1 - depth2);
    }

    private static int GetDescendantDepth(AncestralTree descendant)
    {
        var depth = 0;
        while (descendant.Ancestor != null)
        {
            depth++;
            descendant = descendant.Ancestor;
        }

        return depth;
    }

    private static AncestralTree GetCommonAncestor(AncestralTree lowerTree, AncestralTree higherTree, int depthDiff)
    {
        while (depthDiff != 0)
        {
            lowerTree = lowerTree.Ancestor;
            depthDiff--;
        }

        while (lowerTree.Name != higherTree.Name)
        {
            higherTree = higherTree.Ancestor;
            lowerTree = lowerTree.Ancestor;
        }

        return lowerTree;
    }
}