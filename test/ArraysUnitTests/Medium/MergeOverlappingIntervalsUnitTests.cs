using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class MergeOverlappingIntervalsUnitTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestGetMergeOverlappingIntervals(int[][] array, int[][] expectedResult)
    {
        var result = MergeOverlappingIntervals.GetMergeOverlappingIntervals(array);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[][], int[][]> GetTestData
    {
        get
        {
            var data = new TheoryData<int[][], int[][]>();
            {
                data.Add(
                    new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } },
                    new[] { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } }
                );
                data.Add(
                    new[] { new[] { 1, 4 }, new[] { 4, 5 } },
                    new[] { new[] { 1, 5 } }
                );
                data.Add(
                    new[] { new[] { 1, 4 }, new[] { 0, 2 }, new[] { 3, 5 } },
                    new[] { new[] { 0, 5 } }
                );
                data.Add(
                    new[] { new[] { 1, 4 }, new[] { 5, 6 } },
                    new[] { new[] { 1, 4 }, new[] { 5, 6 } }
                );
                data.Add(
                    new[] { new[] { 1, 10 }, new[] { 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 } },
                    new[] { new[] { 1, 10 } }
                );
                data.Add(
                    new[] { new[] { 1, 2 } },
                    new[] { new[] { 1, 2 } }
                );
            }
            return data;
        }
    }
}