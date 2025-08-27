using BinaryTrees.Easy;
using BinaryTrees.Models;

namespace BinarySumsUnitTests.Easy
{
    public class BranchSumsUnitTests
    {
        [Theory]
        [MemberData(nameof(GetBranchSumsData))]
        public void TestGetBranchSums(BinaryTree input, int[] expectedResult)
        {
            var result = BranchSums.GetBranchSums(input);
            Assert.Equivalent(expectedResult, result);
        }

        public static IEnumerable<object[]> GetBranchSumsData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[]
                    {
                        new BinaryTree(1, new BinaryTree(2, new BinaryTree(4, new BinaryTree(8, null, null), new BinaryTree(9, null, null)), new BinaryTree(5, new BinaryTree(10, null, null), null)),
                            new BinaryTree(3, new BinaryTree(6, null, null), new BinaryTree(7, null, null))),
                        new[] { 15, 16, 18, 10, 11 }
                    },
                    new object[]
                    {
                        new BinaryTree(1, null, null),
                        new[] { 1 }
                    },
                    new object[]
                    {
                        new BinaryTree(1, new BinaryTree(2, null, null), null),
                        new[] { 3 }
                    },
                    new object[]
                    {
                        new BinaryTree(1, new BinaryTree(2, null, null), new BinaryTree(3, null, null)),
                        new[] { 3, 4 }
                    },
                };
                return data;
            }
        }
    }
}