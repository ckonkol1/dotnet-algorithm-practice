using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class MoveElementToEndUnitTests
{
    [Theory]
    [MemberData(nameof(GetThreeNumberSumData))]
    public void TestMoveElementToEndFast(List<int> array, int targetSum, List<int> expectedResult)
    {
        var result = MoveElementToEnd.MoveElementToEndFast(array, targetSum);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<List<int>, int, List<int>> GetThreeNumberSumData
    {
        get
        {
            var data = new TheoryData<List<int>, int, List<int>>
            {
                { [2, 1, 2, 2, 2, 3, 4, 2], 2, [4, 1, 3, 2, 2, 2, 2, 2] },
                { [], 3, [] },
                { [1, 2, 4, 5, 6], 3, [1, 2, 4, 5, 6] },
                { [3, 3, 3, 3, 3], 3, [3, 3, 3, 3, 3] },
                { [3, 1, 2, 4, 5], 3, [5, 1, 2, 4, 3] },
                { [1, 2, 4, 5, 3], 3, [1, 2, 4, 5, 3] },
                { [1, 2, 3, 4, 5], 3, [1, 2, 5, 4, 3] },
                { [2, 4, 2, 5, 6, 2, 2], 2, [6, 4, 5, 2, 2, 2, 2] },
                { [5, 5, 5, 5, 5, 5, 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12], 5, [12, 11, 10, 9, 8, 7, 1, 2, 3, 4, 6, 5, 5, 5, 5, 5, 5] },
                { [1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 5, 5, 5, 5, 5, 5], 5, [1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 5, 5, 5, 5, 5, 5] },
                { [5, 1, 2, 5, 5, 3, 4, 6, 7, 5, 8, 9, 10, 11, 5, 5, 12], 5, [12, 1, 2, 11, 10, 3, 4, 6, 7, 9, 8, 5, 5, 5, 5, 5, 5] },
            };
            return data;
        }
    }
}