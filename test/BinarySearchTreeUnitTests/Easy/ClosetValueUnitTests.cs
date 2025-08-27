using BinarySearchTree.Easy;
using BinarySearchTree.Models;

namespace BinarySearchTreeUnitTests.Easy
{
    public class ClosetValueUnitTests
    {
        [Theory]
        [MemberData(nameof(GetClosetValueData))]
        public void TestGetBranchSums(BST input, int target, int expectedResult)
        {
            var result = ClosestValue.FindClosestValueInBst(input, target);
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> GetClosetValueData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[]
                    {
                        new BST(10, new BST(5, new BST(2, new BST(1, null!, null!), null!), new BST(5, null!, null!)), new BST(15, new BST(13, null!, new BST(14, null!, null!)), new BST(22, null!, null!))),
                        12,
                        13,
                    },
                };
                return data;
            }
        }
    }
}