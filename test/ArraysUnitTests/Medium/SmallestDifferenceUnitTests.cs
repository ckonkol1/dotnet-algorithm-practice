using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class SmallestDifferenceUnitTests
{
    [Theory]
    [MemberData(nameof(GetSmallestDifferenceData))]
    public void TestSmallestDifferenceFast(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
    {
        var result = SmallestDifference.SmallestDifferenceFast(arrayOne, arrayTwo);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetSmallestDifferenceData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { -1, 5, 10, 20, 28, 3 }, new[] { 26, 134, 135, 15, 17 }, new[] { 28, 26 } },
                new object[] { new[] { -1, 5, 10, 20, 3 }, new[] { 26, 134, 135, 15, 17 }, new[] { 20, 17 } },
                new object[] { new[] { 10, 0, 20, 25 }, new[] { 1005, 1006, 1014, 1032, 1031 }, new[] { 25, 1005 } },
                new object[] { new[] { 10, 0, 20, 25, 2200 }, new[] { 1005, 1006, 1014, 1032, 1031 }, new[] { 25, 1005 } },
                new object[] { new[] { 10, 0, 20, 25, 2000 }, new[] { 1005, 1006, 1014, 1032, 1031 }, new[] { 2000, 1032 } },
                new object[] { new[] { 240, 124, 86, 111, 2, 84, 954, 27, 89 }, new[] { 1, 3, 954, 19, 8 }, new[] { 954, 954 } },
                new object[] { new[] { 0, 20 }, new[] { 21, -2 }, new[] { 20, 21 } },
                new object[] { new[] { 10, 1000 }, new[] { -1441, -124, -25, 1014, 1500, 660, 410, 245, 530 }, new[] { 1000, 1014 } },
                new object[] { new[] { 10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123 }, new[] { -1441, -124, -25, 1014, 1500, 660, 410, 245, 530 }, new[] { -123, -124 } },
                new object[] { new[] { 10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530 }, new[] { -1441, -124, -25, 1014, 1500, 660, 410, 245, 530 }, new[] { 530, 530 } },
            };
            return data;
        }
    }
}