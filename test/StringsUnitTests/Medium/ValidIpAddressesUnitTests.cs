using Strings.Medium;

namespace StringsUnitTests.Medium;

public class ValidIpAddressesUnitTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestGetValidIpAddresses(string input, List<string> expectedResult)
    {
        var result = ValidIpAddresses.GetValidIPAddresses(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<string, List<string>> GetTestData
    {
        get
        {
            var data = new TheoryData<string, List<string>>
            {
                { "0000", ["0.0.0.0"] },
                { "101023", ["1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3"] },
                { "1111", ["1.1.1.1"] },
                { "010010", ["0.10.0.10", "0.100.1.0"] },
                { "255255255255", ["255.255.255.255"] },
                { "256256256256", [] }, // No valid IPs, numbers > 255
                { "123", [] }, // Too short, no valid IPs
                { "1234567890123", [] }, // Too long, no valid IPs
                { "100100100100", ["100.100.100.100"] },
                { "000256", [] }, // Segment > 255
                { "027924558730", [] } // No valid IPs, segments with leading zeros and >255
            };

            return data;
        }
    }
}