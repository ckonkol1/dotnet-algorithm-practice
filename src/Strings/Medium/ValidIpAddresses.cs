namespace Strings.Medium;

/*
 *Valid IP Addresses
   You're given a string of length 12 or smaller, containing only digits. Write a function that returns all the possible IP addresses that can be
   created by inserting three . sin the string.
   An IP address is a sequence of four positive integers that are separated by . s. where each individual integer is within the range
   o - 255 inclusive.
   An IP address isn't valid if any of the individual integers contains leading e s. For example, "192.168.@.1" isa valid IP address, but
   "192.168.69.1" and "192.168.6.61" aren't, because they contain "60" and 01 , respectively. Another example of a valid IP
   address is "99.1.1.10" ; conversely, "991.1.1.6" isn't valid, because "991" is greater than 255.
   Your function should return the IP addresses in string format and in no particular order.
   If no valid IP addresses can be created from the
   string, your function should return an empty list.

    Sample Input:  string = "1921680"
    Sample Output: [
       "1.9.216.80",
       "1.92.16.80",
       "1.92.168.0",
       "19.2.16.80",
       "19.2.168.0",
       "19.21.6.80",
       "19.21.68.80-,
       "19.216.8.0,
       "192.1.6.80",
       "192.1.68.0,
       "192.16.8.0
    ]
    O(1) time | O(1) space - where n is the length of the input string
 */
public static class ValidIpAddresses
{
    public static List<string> GetValidIPAddresses(string str)
    {
        var validIpAddresses = new List<string>();

        if (str.Length < 4 || str.Length > 12)
        {
            return validIpAddresses;
        }

        for (var i = 1; i < Math.Min(str.Length, 4); i++)
        {
            var currentIpAddress = new string[4];
            currentIpAddress[0] = str.Substring(0, i);
            if (!IsValid(currentIpAddress[0]))
            {
                continue;
            }

            for (var j = i + 1; j < Math.Min(str.Length, i + 4); j++)
            {
                currentIpAddress[1] = str.Substring(i, j - i);

                if (!IsValid(currentIpAddress[1]))
                {
                    continue;
                }

                for (var k = j + 1; k < Math.Min(str.Length, j + 4); k++)
                {
                    currentIpAddress[2] = str.Substring(j, k - j);
                    currentIpAddress[3] = str.Substring(k);

                    if (IsValid(currentIpAddress[2]) && IsValid(currentIpAddress[3]))
                    {
                        validIpAddresses.Add(string.Join(".", currentIpAddress));
                    }
                }
            }
        }

        return validIpAddresses;
    }

    private static bool IsValid(string str)
    {
        var num = int.Parse(str);
        if (num > 255)
        {
            return false;
        }

        return str.Length == num.ToString().Length;
    }
}