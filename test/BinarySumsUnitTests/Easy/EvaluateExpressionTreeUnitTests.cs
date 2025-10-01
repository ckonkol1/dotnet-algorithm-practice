using BinaryTrees.Easy;
using BinaryTrees.Models;

namespace BinaryTreeUnitTests.Easy;

public class EvaluateExpressionTreeUnitTests
{
    [Theory]
    [MemberData(nameof(GetEvaluateExpressionTreeData))]
    public void TestEvaluateExpressionTree(BinaryTree input, int expectedResult)
    {
        var result = EvaluateExpressionTree.GetEvaluateExpressionTree(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<BinaryTree, int> GetEvaluateExpressionTreeData =>
        new()
        {
            { new BinaryTree(-1, new BinaryTree(2, null!, null!), new BinaryTree(3, null!, null!)), 5 },
            { new BinaryTree(-2, new BinaryTree(2, null!, null!), new BinaryTree(3, null!, null!)), -1 },
            { new BinaryTree(-2, new BinaryTree(3, null!, null!), new BinaryTree(2, null!, null!)), 1 },
            { new BinaryTree(-3, new BinaryTree(2, null!, null!), new BinaryTree(3, null!, null!)), 0 },
            { new BinaryTree(-3, new BinaryTree(3, null!, null!), new BinaryTree(2, null!, null!)), 1 },
            { new BinaryTree(-4, new BinaryTree(2, null!, null!), new BinaryTree(3, null!, null!)), 6 },
            { new BinaryTree(-1, new BinaryTree(2, null!, null!), new BinaryTree(-2, new BinaryTree(4, null!, null!), new BinaryTree(5, null!, null!))), 1 },
            { new BinaryTree(-3, new BinaryTree(10, null!, null!), new BinaryTree(-2, new BinaryTree(4, null!, null!), new BinaryTree(6, null!, null!))), -5 },
        };
}