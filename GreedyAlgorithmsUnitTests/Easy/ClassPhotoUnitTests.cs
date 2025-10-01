using GreedyAlgorithms.Easy;

namespace GreedyAlgorithmsUnitTests.Easy;

public class ClassPhotoUnitTests
{
    [Theory]
    [MemberData(nameof(GetClassPhotoData))]
    public void TestGetMinimumWaitingTimeData(List<int> redShirts, List<int> blueShirts, bool expectedResult)
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
                { [5, 8, 1, 3, 4], [6, 9, 2, 4, 5], true }
            };
            return data;
        }
    }
}