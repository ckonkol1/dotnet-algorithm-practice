namespace FamousAlgorithmsUnitTests.Medium
{
    public class KadanesAlgorithmUnitTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void TestGetProductSum(int[] array, int expectedResult)
        {
            var result = KadanesAlgorithm.GetKadanesAlgorithm(array);
            Assert.Equivalent(expectedResult, result);
        }

        public static TheoryData<int[], int> GetData
        {
            get
            {
                var data = new TheoryData<int[], int>();
                data.Add([-2, 1, -3, 4, -1, 2, 1, -5, 4], 6);
                data.Add([1], 1);
                data.Add([5, 4, -1, 7, 8], 23);
                data.Add([-1, -2, -3, -4], -1);
                data.Add([0, 0, 0, 0], 0);
                data.Add([2, -1, 2, 3, 4, -5], 10);
                data.Add([-2, -3, 4, -1, -2, 1, 5, -3], 7);
                data.Add([3, -2, 5, -1], 6);
                data.Add([-5, 1, 2, 3, -1, 2, -1], 7);
                data.Add([1, 2, 3, 4, 5], 15);
                return data;
            }
        }
    }
}