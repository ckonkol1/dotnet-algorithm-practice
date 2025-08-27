using BinaryTrees.Easy;
using BinaryTrees.Models;

namespace BinarySumsUnitTests.Easy;

public class NodeDepthUnitTests
{
    [Theory]
    [MemberData(nameof(GetNodeDepthData))]
    public void TestGetNodeDepth(BinaryTree input, int expectedResult)
    {
        var result = NodeDepth.GetNodeDepth(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static IEnumerable<object[]> GetNodeDepthData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new BinaryTree(1, new BinaryTree(2, new BinaryTree(4, new BinaryTree(8, null, null), new BinaryTree(9, null, null)), new BinaryTree(5, new BinaryTree(10, null, null), null)),
                        new BinaryTree(3, new BinaryTree(6, null, null), new BinaryTree(7, null, null))),
                    19
                },
                new object[]
                {
                    new BinaryTree(1, null, null),
                    0
                },
                new object[]
                {
                    new BinaryTree(1, new BinaryTree(2, null, null), null),
                    1
                },
                new object[]
                {
                    new BinaryTree(1, new BinaryTree(2, null, null), new BinaryTree(3, null, null)),
                    2
                },
            };
            return data;
        }
    }
}