using GreedyAlgorithms.Easy;

namespace GreedyAlgorithmsUnitTests.Easy;

public class OptimalFreelancingUnitTests
{
    [Theory]
    [MemberData(nameof(GetJobsData))]
    public void TestGetOptimalFreelancing(Dictionary<string, int>[] jobs, int expectedResult)
    {
        var result = OptimalFreelancing.GetOptimalFreelancing(jobs);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<Dictionary<string, int>[], int> GetJobsData
    {
        get
        {
            var data = new TheoryData<Dictionary<string, int>[], int>();

            data.Add([], 0);
            data.Add(
                [new Dictionary<string, int> { { "deadline", 1 }, { "payment", 100 } }],
                100
            );

            data.Add(
                [
                    new Dictionary<string, int> { { "deadline", 1 }, { "payment", 100 } },
                    new Dictionary<string, int> { { "deadline", 2 }, { "payment", 200 } },
                    new Dictionary<string, int> { { "deadline", 3 }, { "payment", 300 } }
                ],
                600
            );

            data.Add(
                [
                    new Dictionary<string, int> { { "deadline", 1 }, { "payment", 100 } },
                    new Dictionary<string, int> { { "deadline", 1 }, { "payment", 200 } },
                    new Dictionary<string, int> { { "deadline", 2 }, { "payment", 50 } }
                ],
                250
            );

            data.Add(
                [
                    new Dictionary<string, int> { { "deadline", 1 }, { "payment", 10 } },
                    new Dictionary<string, int> { { "deadline", 2 }, { "payment", 20 } },
                    new Dictionary<string, int> { { "deadline", 3 }, { "payment", 30 } },
                    new Dictionary<string, int> { { "deadline", 4 }, { "payment", 40 } },
                    new Dictionary<string, int> { { "deadline", 5 }, { "payment", 50 } },
                    new Dictionary<string, int> { { "deadline", 6 }, { "payment", 60 } },
                    new Dictionary<string, int> { { "deadline", 7 }, { "payment", 70 } },
                    new Dictionary<string, int> { { "deadline", 7 }, { "payment", 100 } }
                ],
                370
            );

            data.Add(
                [
                    new Dictionary<string, int> { { "deadline", 8 }, { "payment", 1000 } },
                    new Dictionary<string, int> { { "deadline", 1 }, { "payment", 10 } }
                ],
                1010
            );

            return data;
        }
    }
}