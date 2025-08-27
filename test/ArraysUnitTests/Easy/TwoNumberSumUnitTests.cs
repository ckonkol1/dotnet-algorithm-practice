using Arrays.Easy;

namespace ArraysUnitTests.Easy
{
    public class TwoNumberSumUnitTests
    {
        [Theory]
        [MemberData(nameof(GetTwoNumberSumData))]
        public void TestTwoNumberSumArray(int[] array, int targetSum, int[] expectedResult)
        {
            var result = TwoNumberSum.TwoNumberSumArray(array, targetSum);
            Assert.Equal(expectedResult.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Theory]
        [MemberData(nameof(GetTwoNumberSumData))]
        public void TestTwoNumberSumDictionary(int[] array, int targetSum, int[] expectedResult)
        {
            var result = TwoNumberSum.TwoNumberSumDictionary(array, targetSum);
            Assert.Equal(expectedResult.OrderBy(x => x), result.OrderBy(x => x));
        }

        public static IEnumerable<object[]> GetTwoNumberSumData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[] { new[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10, new[] { 11, -1 } },
                    new object[] { new[] { 4, 6 }, 10, new[] { 4, 6 } },
                    new object[] { new[] { 4, 6, 1 }, 5, new[] { 4, 1 } },
                    new object[] { new[] { 4, 6, 1, -3 }, 3, new[] { 6, -3 } },
                    new object[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 17, new[] { 8, 9 } },
                    new object[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 }, 18, new[] { 3, 15 } },
                    new object[] { new[] { -7, -5, -3, -1, 0, 1, 3, 5, 7 }, -5, new[] { -5, 0 } },
                    new object[] { new[] { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 }, 163, new[] { 210, -47 } },
                    new object[] { new[] { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 }, 164, new int[] { } },
                    new object[] { new[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 15, new int[] { } },
                    new object[] { new[] { 14 }, 15, new int[] { } },
                    new object[] { new[] { 15 }, 15, new int[] { } },
                };
                return data;
            }
        }
    }
}