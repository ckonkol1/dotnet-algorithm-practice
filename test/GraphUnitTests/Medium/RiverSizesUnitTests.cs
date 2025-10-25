using Graph.Medium;

namespace GraphUnitTests.Medium;

public class RiverSizesUnitTests
{
    [Theory]
    [MemberData(nameof(GetRiverSizesData))]
    public void TestGetRiverSizes(int[,] matrix, List<int> expected)
    {
        var result = RiverSizes.GetRiverSizes(matrix);
        result.Sort();
        expected.Sort();
        Assert.Equal(expected, result);
    }

    public static TheoryData<int[,], List<int>> GetRiverSizesData => new()
    {
        {
            new int[,]
            {
                { 1, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 0 },
                { 0, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 0, 1, 1, 0 }
            },
            [2, 1, 5, 2, 2]
        },
        {
            new int[,]
            {
                { 1, 0, 1 },
                { 0, 1, 0 },
                { 1, 0, 1 }
            },
            [1, 1, 1, 1, 1]
        },
        {
            new int[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            },
            []
        },
        {
            new int[,]
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            },
            [9]
        },
        {
            new int[,]
            {
                { 1 }
            },
            [1]
        },
        {
            new int[,]
            {
                { 0 }
            },
            []
        }
    };
}