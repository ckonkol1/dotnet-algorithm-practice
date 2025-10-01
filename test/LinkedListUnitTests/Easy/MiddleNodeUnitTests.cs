using LinkedList.Easy;

namespace LinkedListUnitTests.Easy;

public class MiddleNodeUnitTests
{
    [Theory]
    [MemberData(nameof(GetMiddleNodeData))]
    public void TestGetMiddleNode(LinkedList.LinkedList input, LinkedList.LinkedList expectedResult)
    {
        var result = MiddleNode.GetMiddleNode(input);
        Assert.Equivalent(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetMiddleNodeData))]
    public void TestGetMiddleNodeSlowAndFastPointers(LinkedList.LinkedList input, LinkedList.LinkedList expectedResult)
    {
        var result = MiddleNode.GetMiddleNodeSlowAndFastPointers(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static IEnumerable<object[]> GetMiddleNodeData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new LinkedList.LinkedList(1,
                        new LinkedList.LinkedList(1,
                            new LinkedList.LinkedList(1,
                                new LinkedList.LinkedList(3,
                                    new LinkedList.LinkedList(4,
                                        new LinkedList.LinkedList(4,
                                            new LinkedList.LinkedList(4,
                                                new LinkedList.LinkedList(4,
                                                    new LinkedList.LinkedList(5,
                                                        new LinkedList.LinkedList(6,
                                                            new LinkedList.LinkedList(6, null))))))))))),
                    new LinkedList.LinkedList(4,
                        new LinkedList.LinkedList(4,
                            new LinkedList.LinkedList(4,
                                new LinkedList.LinkedList(5,
                                    new LinkedList.LinkedList(6,
                                        new LinkedList.LinkedList(6, null)))))),
                },
                new object[]
                {
                    new LinkedList.LinkedList(1,
                        new LinkedList.LinkedList(2,
                            new LinkedList.LinkedList(3, null))),
                    new LinkedList.LinkedList(2,
                        new LinkedList.LinkedList(3, null)),
                },
                new object[]
                {
                    new LinkedList.LinkedList(1, null),
                    new LinkedList.LinkedList(1, null),
                }
            };
            return data;
        }
    }
}