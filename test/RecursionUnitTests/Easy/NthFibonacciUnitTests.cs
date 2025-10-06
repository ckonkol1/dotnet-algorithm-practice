using Recursion.Easy;

namespace RecursionUnitTests.Easy;

public class NthFibonacciUnitTests
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 1)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 8)]
    [InlineData(8, 13)]
    [InlineData(9, 21)]
    [InlineData(10, 34)]
    public void TestGetProductSum(int num, int expectedResult)
    {
        var result = NthFibonacci.GetNthFib(num);
        Assert.Equivalent(expectedResult, result);
    }
}