using Arrays.Easy;

namespace ArraysUnitTests.Easy
{
    public class TransposeMatrixUnitTests
    {
        [Theory]
        [MemberData(nameof(GetTransposeMatrixData))]
        public void TestTransposeMatrixFast(int[,] matrix, int[,] expectedResult)
        {
            var result = TransposeMatrix.TransposeMatrixFast(matrix);
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> GetTransposeMatrixData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[] { new[,] { { 1 } }, new[,] { { 1 } } },
                    new object[] { new[,] { { 1 }, { -1 } }, new[,] { { 1, -1 } } },
                    new object[] { new[,] { { 1, 2, 3 } }, new[,] { { 1 }, { 2 }, { 3 } } },
                    new object[] { new[,] { { 1 }, { 2 }, { 3 } }, new[,] { { 1, 2, 3 } } },
                    new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6 } }, new[,] { { 1, 4 }, { 2, 5 }, { 3, 6 } } },
                    new object[] { new[,] { { 0, 0, 0 }, { 1, 1, 1 } }, new[,] { { 0, 1 }, { 0, 1 }, { 0, 1 } } },
                    new object[] { new[,] { { 0, 1 }, { 0, 1 }, { 0, 1 } }, new[,] { { 0, 0, 0 }, { 1, 1, 1 } } },
                    new object[] { new[,] { { 0, 0, 0 }, { 0, 0, 0 } }, new[,] { { 0, 0 }, { 0, 0 }, { 0, 0 } } },
                    new object[] { new[,] { { 1, 4 }, { 2, 5 }, { 3, 6 } }, new[,] { { 1, 2, 3 }, { 4, 5, 6 } } },
                    new object[] { new[,] { { -7, -7 }, { 100, 12 }, { -33, 17 } }, new[,] { { -7, 100, -33 }, { -7, 12, 17 } } },
                    new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, new[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } } },
                    new object[] { new[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } }, new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } },
                    new object[] { new[,] { { 5, 6, 3, -3, 12 }, { -3, 6, 5, 2, -1 }, { 0, 0, 3, 12, 3 } }, new[,] { { 5, -3, 0 }, { 6, 6, 0 }, { 3, 5, 3 }, { -3, 2, 12 }, { 12, -1, 3 } } },
                    new object[] { new[,] { { 0, -1, -2, -3 }, { 4, 5, 6, 7 }, { 2, 3, -2, -3 }, { 42, 100, 30, -42 } }, new[,] { { 0, 4, 2, 42 }, { -1, 5, 3, 100 }, { -2, 6, -2, 30 }, { -3, 7, -3, -42 } } },
                    new object[] { new[,] { { 1234, 6935, 4205 }, { -23459, 314159, 0 }, { 100, 3, 987654 } }, new[,] { { 1234, -23459, 100 }, { 6935, 314159, 3 }, { 4205, 0, 987654 } } },
                };
                return data;
            }
        }
    }
}