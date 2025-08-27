using BinaryTrees.Easy;
using BinaryTrees.Models;

namespace BinarySumsUnitTests.Easy;

public class EvaluateExpressionTreeUnitTests
{
    [Theory]
    [MemberData(nameof(GetEvaluateExpressionTreeData))]
    public void TestEvaluateExpressionTree(BinaryTree input, int expectedResult)
    {
        var result = EvaluateExpressionTree.GetEvaluateExpressionTree(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static IEnumerable<object[]> GetEvaluateExpressionTreeData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new BinaryTree(-1, new BinaryTree(2, null, null), new BinaryTree(3, null, null)),
                    5
                },
                new object[]
                {
                    new BinaryTree(-2, new BinaryTree(2, null, null), new BinaryTree(3, null, null)),
                    -1
                },
                new object[]
                {
                    new BinaryTree(-2, new BinaryTree(3, null, null), new BinaryTree(2, null, null)),
                    1
                },
                new object[]
                {
                    new BinaryTree(-3, new BinaryTree(2, null, null), new BinaryTree(3, null, null)),
                    0
                },
                new object[]
                {
                    new BinaryTree(-3, new BinaryTree(3, null, null), new BinaryTree(2, null, null)),
                    1
                },
                new object[]
                {
                    new BinaryTree(-4, new BinaryTree(2, null, null), new BinaryTree(3, null, null)),
                    6
                },
                new object[]
                {
                    new BinaryTree(-1, new BinaryTree(2, null, null), new BinaryTree(-2, new BinaryTree(4, null, null), new BinaryTree(5, null, null))),
                    1
                },
                new object[]
                {
                    new BinaryTree(-3, new BinaryTree(10, null, null), new BinaryTree(-2, new BinaryTree(4, null, null), new BinaryTree(6, null, null))),
                    -5
                },
            };
            return data;
        }
    }
}