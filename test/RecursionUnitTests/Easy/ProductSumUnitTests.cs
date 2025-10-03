using Recursion.Easy;

namespace RecursionUnitTests.Easy
{
    public class ProductSumUnitTests
    {
        [Theory]
        [MemberData(nameof(GetProductSumData))]
        public void TestGetProductSum(List<object> array, int expectedResult)
        {
            var result = ProductSum.GetProductSum(array);
            Assert.Equivalent(expectedResult, result);
        }

        public static TheoryData<List<object>, int> GetProductSumData
        {
            get
            {
                var data = new TheoryData<List<object>, int>
                {
                    { [1, 2, 3], 6 },
                    { [1, 2, new List<object> { 3, 4 }], 1 + 2 + 2 * (3 + 4) },
                    { [5, new List<object> { 2, new List<object> { 7 }, 3 }, 6], 5 + 2 * (2 + 3 * (7) + 3) + 6 },
                    { [1, new List<object> { 2, new List<object> { 3, new List<object> { 4 } } }], 1 + 2 * (2 + 3 * (3 + 4 * (4))) },
                };
                return data;
            }
        }
    }
}