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
                    [[1, 3], [2, 6], [8, 10], [15, 18]],
                    [[1, 6], [8, 10], [15, 18]]
                );
                data.Add(
                    [[1, 4], [4, 5]],
                    [[1, 5]]
                );
                data.Add(
                    [[1, 4], [0, 2], [3, 5]],
                    [[0, 5]]
                );
                data.Add(
                    [[1, 4], [5, 6]],
                    [[1, 4], [5, 6]]
                );
                data.Add(
                    [[1, 10], [2, 3], [4, 5], [6, 7]],
                    [[1, 10]]
                );
                data.Add(
                    [[1, 2]],
                    [[1, 2]]
                );
            }
            return data;
        }
    }
}