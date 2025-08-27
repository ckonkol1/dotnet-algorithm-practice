using Arrays.Easy;

namespace ArraysUnitTests.Easy;

public class TournamentWinnerUnitTests
{
    [Theory]
    [MemberData(nameof(GetTournamentWinnerData))]
    public void TestValidateSubsequenceFast(List<List<string>> competitions, List<int> results, string expectedResult)
    {
        var result = TournamentWinner.TournamentWinnerFast(competitions, results);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetTournamentWinnerData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "HTML", "C#" },
                        new() { "C#", "Python" },
                        new() { "Python", "HTML" }
                    },
                    new List<int> { 0, 0, 1 },
                    "Python"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "HTML", "Java" },
                        new() { "Java", "Python" },
                        new() { "Python", "HTML" }
                    },
                    new List<int> { 0, 1, 1 },
                    "Java"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "HTML", "Java" },
                        new() { "Java", "Python" },
                        new() { "Python", "HTML" },
                        new() { "C#", "Python" },
                        new() { "Java", "C#" },
                        new() { "C#", "HTML" }
                    },
                    new List<int> { 0, 1, 1, 1, 0, 1 },
                    "C#"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "HTML", "Java" },
                        new() { "Java", "Python" },
                        new() { "Python", "HTML" },
                        new() { "C#", "Python" },
                        new() { "Java", "C#" },
                        new() { "C#", "HTML" },
                        new() { "SQL", "C#" },
                        new() { "HTML", "SQL" },
                        new() { "SQL", "Python" },
                        new() { "SQL", "Java" }
                    },
                    new List<int> { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                    "C#"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "Bulls", "Eagles" },
                    },
                    new List<int> { 1 },
                    "Bulls"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "Bulls", "Eagles" },
                        new() { "Bulls", "Bears" },
                        new() { "Bears", "Eagles" },
                    },
                    new List<int> { 0, 0, 0 },
                    "Eagles"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "Bulls", "Eagles" },
                        new() { "Bulls", "Bears" },
                        new() { "Bulls", "Monkeys" },
                        new() { "Eagles", "Bears" },
                        new() { "Eagles", "Monkeys" },
                        new() { "Bears", "Monkeys" },
                    },
                    new List<int> { 1, 1, 1, 1, 1, 1 },
                    "Bulls"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "AlgoMasters", "FrontPage Freebirds" },
                        new() { "Runtime Terror", "Static Startup" },
                        new() { "WeC#", "Hypertext Assassins" },
                        new() { "AlgoMasters", "WeC#" },
                        new() { "Static Startup", "Hypertext Assassins" },
                        new() { "Runtime Terror", "FrontPage Freebirds" },
                        new() { "AlgoMasters", "Runtime Terror" },
                        new() { "Hypertext Assassins", "FrontPage Freebirds" },
                        new() { "Static Startup", "WeC#" },
                        new() { "AlgoMasters", "Static Startup" },
                        new() { "FrontPage Freebirds", "WeC#" },
                        new() { "Hypertext Assassins", "Runtime Terror" },
                        new() { "AlgoMasters", "Hypertext Assassins" },
                        new() { "WeC#", "Runtime Terror" },
                        new() { "FrontPage Freebirds", "Static Startup" }
                    },
                    new List<int> { 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0 },
                    "AlgoMasters"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "HTML", "Java" },
                        new() { "Java", "Python" },
                        new() { "Python", "HTML" },
                        new() { "C#", "Python" },
                        new() { "Java", "C#" },
                        new() { "C#", "HTML" },
                        new() { "SQL", "C#" },
                        new() { "HTML", "SQL" },
                        new() { "SQL", "Python" },
                        new() { "SQL", "Java" }
                    },
                    new List<int> { 0, 0, 0, 0, 0, 0, 1, 0, 1, 1 },
                    "SQL"
                },
                new object[]
                {
                    new List<List<string>>()
                    {
                        new() { "A", "B" }
                    },
                    new List<int> { 0 },
                    "B"
                }
            };
            return data;
        }
    }
}