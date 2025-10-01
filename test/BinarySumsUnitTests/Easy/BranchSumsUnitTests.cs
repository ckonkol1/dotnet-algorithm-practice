using BinaryTrees.Easy;
using BinaryTrees.Models;

namespace BinaryTreeUnitTests.Easy
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

        public static TheoryData<BinaryTree, int[]> GetBranchSumsData
        {
            get
            {
                var data = new TheoryData<BinaryTree, int[]>
                {
                    {
                        new BinaryTree(1, new BinaryTree(2, new BinaryTree(4, new BinaryTree(8, null!, null!), new BinaryTree(9, null!, null!)), new BinaryTree(5, new BinaryTree(10, null!, null!), null!)),
                            new BinaryTree(3, new BinaryTree(6, null!, null!), new BinaryTree(7, null!, null!))),
                        (int[]) [15, 16, 18, 10, 11]
                    },


                    {
                        new BinaryTree(1, null!, null!),
                        (int[]) [1]
                    },

                    {
                        new BinaryTree(1, new BinaryTree(2, null!, null!), null!),
                        (int[]) [3]
                    },

                    {
                        new BinaryTree(1, new BinaryTree(2, null!, null!), new BinaryTree(3, null!, null!)),
                        (int[]) [3, 4]
                    },
                };

                return data;
            }
        }
    }
}