using Graph.Medium;
using Graph.Models;

namespace GraphUnitTests.Medium;

public class YoungestCommonAncestorUnitTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestGetYoungestCommonAncestor(AncestralTree topAncestralTree, AncestralTree descendantOne, AncestralTree descendantTwo, AncestralTree expectedResult)
    {
        var result = YoungestCommonAncestor.GetYoungestCommonAncestor(topAncestralTree, descendantOne, descendantTwo);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<AncestralTree, AncestralTree, AncestralTree, AncestralTree> GetTestData
    {
        get
        {
            var data = new TheoryData<AncestralTree, AncestralTree, AncestralTree, AncestralTree>
            {
                {
                    new AncestralTree('A', null),
                    new AncestralTree('F', new AncestralTree('E', new AncestralTree('C', new AncestralTree('A', null)))),
                    new AncestralTree('D', new AncestralTree('C', new AncestralTree('A', null))),
                    new AncestralTree('C', new AncestralTree('A', null))
                },
                // Test: direct siblings, common ancestor is A
                {
                    new AncestralTree('A', null),
                    new AncestralTree('B', new AncestralTree('A', null)),
                    new AncestralTree('C', new AncestralTree('A', null)),
                    new AncestralTree('A', null)
                },
                // Test: one is ancestor of the other
                {
                    new AncestralTree('A', null),
                    new AncestralTree('C', new AncestralTree('B', new AncestralTree('A', null))),
                    new AncestralTree('B', new AncestralTree('A', null)),
                    new AncestralTree('B', new AncestralTree('A', null))
                },
                // Test: both are the same node
                {
                    new AncestralTree('A', null),
                    new AncestralTree('D', new AncestralTree('B', new AncestralTree('A', null))),
                    new AncestralTree('D', new AncestralTree('B', new AncestralTree('A', null))),
                    new AncestralTree('D', new AncestralTree('B', new AncestralTree('A', null)))
                },
                // Test: deeper tree, ancestor is not root
                {
                    new AncestralTree('A', null),
                    new AncestralTree('F', new AncestralTree('E', new AncestralTree('B', new AncestralTree('A', null)))),
                    new AncestralTree('D', new AncestralTree('B', new AncestralTree('A', null))),
                    new AncestralTree('B', new AncestralTree('A', null))
                }
            };

            return data;
        }
    }
}