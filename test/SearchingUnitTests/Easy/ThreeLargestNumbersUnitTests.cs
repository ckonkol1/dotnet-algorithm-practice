using Searching.Easy;

namespace SearchingUnitTests.Easy
{
    public class ThreeLargestNumbersUnitTests
    {
        [Theory]
        [MemberData(nameof(GetThreeLargestNumbersData))]
        public void TestThreeLargestNumbers(int[] input, int[] expectedResult)
        {
            var result = ThreeLargestNumbers.FindThreeLargestNumbers(input);
            Assert.Equivalent(expectedResult, result);
        }

        public static IEnumerable<object[]> GetThreeLargestNumbersData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[] { new[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 }, new[] { 18, 141, 541 } },
                    new object[] { new[] { 55, 7, 8 }, new[] { 7, 8, 55 } },
                    new object[] { new[] { 55, 43, 11, 3, -3, 10 }, new[] { 11, 43, 55 } },
                    new object[] { new[] { 7, 8, 3, 11, 43, 55 }, new[] { 11, 43, 55 } },
                    new object[] { new[] { 55, 7, 8, 3, 43, 11 }, new[] { 11, 43, 55 } },
                    new object[] { new[] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }, new[] { 7, 7, 7 } },
                    new object[] { new[] { 7, 7, 7, 7, 7, 7, 8, 7, 7, 7, 7 }, new[] { 7, 7, 8 } },
                    new object[] { new[] { -1, -2, -3, -7, -17, -27, -18, -541, -8, -7, 7 }, new[] { -2, -1, 7 } },
                };
                return data;
            }
        }
    }
}