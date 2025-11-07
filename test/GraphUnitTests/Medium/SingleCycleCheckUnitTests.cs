using Graph.Medium;

namespace GraphUnitTests.Medium;

public class SingleCycleCheckUnitTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestSingleCycleCheck(int[] input, bool expectedResult)
    {
        var result = SingleCycleCheck.HasSingleCycle(input);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[], bool> GetTestData
    {
        get
        {
            var data = new TheoryData<int[], bool>();

            data.Add([2, 3, 1, -4, -4, 2], true); // Single cycle exists
            data.Add([1, 1, 1, 1, 2], false); // Does not visit all elements
            data.Add([2, 2, -1], true); // Jumps skip elements
            data.Add([1, -1, 1, -1], false); // Alternates, never completes cycle
            data.Add([0, 1, 1, 1, 1], false); // Stuck at index 0
            data.Add([1, 1, 1, 1, -4], true); // Single cycle, wraps around
            data.Add([10, -11, -6, -23, 2, 3, 88, 909, -26], false); // Large jumps, single cycle
            data.Add([1], true);
            data.Add([2, 2, 2], true); // All jumps form a cycle

            return data;
        }
    }
}