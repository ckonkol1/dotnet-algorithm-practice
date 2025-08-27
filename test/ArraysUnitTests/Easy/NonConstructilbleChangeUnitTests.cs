using Arrays.Easy;

namespace ArraysUnitTests.Easy;

/*
 *Non-Constructible Change
   Given an array of positive integers representing the values of coins in your possession, write a function that returns the
   minimum amount of change (the minimum sum of money) that you cannot create. The given coins can have any
   positive integer value and aren't necessarily unique (i.e., you can have multiple coins of the same value).
   For example, if you're given coins = [1, 2, 5] , the minimum amount of change that you can't create is 4 . If
   you're given no coins, the minimum amount of change that you can't create is 1 .
 */
public class NonConstructilbleChangeUnitTests
{
    [Theory]
    [MemberData(nameof(GetNonConstructibleChangeData))]
    public void TestNonConstructibleChangeFast(int[] array, int expectedResult)
    {
        var result = NonConstructilbleChange.NonConstructibleChangeFast(array);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetNonConstructibleChangeData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { 5, 7, 1, 1, 2, 3, 22 }, 20 },
                new object[] { new[] { 1, 1, 1, 1, 1 }, 6 },
                new object[] { new[] { 1, 5, 1, 1, 1, 10, 15, 20, 100 }, 55 },
                new object[] { new[] { 6, 4, 5, 1, 1, 8, 9 }, 3 },
                new object[] { Array.Empty<object>(), 1 },
                new object[] { new[] { 87 }, 1 },
                new object[] { new[] { 5, 6, 1, 1, 2, 3, 4, 9 }, 32 },
                new object[] { new[] { 5, 6, 1, 1, 2, 3, 43 }, 19 },
                new object[] { new[] { 1, 1 }, 3 },
                new object[] { new[] { 2 }, 1 },
                new object[] { new[] { 1 }, 2 },
                new object[] { new[] { 109, 2000, 8765, 19, 18, 17, 16, 8, 1, 1, 2, 4 }, 87 },
                new object[] { new[] { 1, 2, 3, 4, 5, 6, 7 }, 29 },
            };
            return data;
        }
    }
}