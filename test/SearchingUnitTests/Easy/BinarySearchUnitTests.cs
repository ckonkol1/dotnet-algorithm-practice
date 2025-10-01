using Searching.Easy;

namespace SearchingUnitTests.Easy
{
    public class BinarySearchUnitTests
    {
        [Theory]
        [MemberData(nameof(GetBinarySearchData))]
        public void TestBinarySearchFast(int[] input, int target, int expectedResult)
        {
            var result = BinarySearch.BinarySearchFast(input, target);
            Assert.Equivalent(expectedResult, result);
        }

        public static IEnumerable<object[]> GetBinarySearchData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 33, 3 },
                    new object[] { (int[]) [1, 5, 23, 111], 111, 3 },
                    new object[] { (int[]) [1, 5, 23, 111], 5, 1 },
                    new object[] { (int[]) [1, 5, 23, 111], 35, -1 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 0, 0 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 1, 1 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 21, 2 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 45, 4 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 61, 6 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 71, 7 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 72, 8 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 73, 9 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73], 70, -1 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73, 355], 355, 10 },
                    new object[] { (int[]) [0, 1, 21, 33, 45, 45, 61, 71, 72, 73, 355], 354, -1 },
                    new object[] { (int[]) [1, 5, 23, 111], 120, -1 },
                    new object[] { (int[]) [5, 23, 111], 3, -1 },
                };
                return data;
            }
        }
    }
}