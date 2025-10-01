using GreedyAlgorithms.Easy;

namespace GreedyAlgorithmsUnitTests.Easy;

public class ClassPhotoUnitTests
{
    [Theory]
    [MemberData(nameof(GetClassPhotoData))]
    public void TestGetClassPhotos(List<int> redShirts, List<int> blueShirts, bool expectedResult)
    {
        var result = ClassPhoto.GetClassPhotos(redShirts, blueShirts);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<List<int>, List<int>, bool> GetClassPhotoData
    {
        get
        {
            var data = new TheoryData<List<int>, List<int>, bool>
            {
                { [5, 8, 1, 3, 4], [6, 9, 2, 4, 5], true },
                { [1, 2, 3], [4, 5, 6], true },
                { [6, 9, 2, 4, 5], [5, 8, 1, 3, 4], true },
                { [5, 5, 5, 5], [5, 5, 5, 5], false },
                { [10, 12, 15], [9, 11, 13], true },
                { [1, 2, 3], [1, 2, 3], false },
                { [7, 8, 9], [5, 6, 7], true },
                { [2, 4, 6], [1, 3, 5], true },
                { [3, 6, 7, 2], [4, 5, 8, 1], false },
                { [1], [2], true },
                { [2], [1], true }
            };
            return data;
        }
    }
}