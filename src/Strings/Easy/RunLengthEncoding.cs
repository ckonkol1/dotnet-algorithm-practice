using System.Text;

namespace Strings.Easy;

/*
 *Run-Length Encoding
   Write a function that takes in a non-empty string and returns its run-length encoding.
   From Wikipedia, "run-length encoding is a form of lossless data compression in which runs of data are stored as a single data value and
   count, rather than as the original run." For this problem, a run of data is any sequence of consecutive, identical characters. So the run
   "AAA" would be run-length-encoded as "3A" .
   To make things more complicated, however, the input string can contain all sorts of special characters, including numbers. And since
   encoded data must be decodable, this means that we can't naively run-length-encode long runs. For example, the run
   "AAAAAAAAAAAA'I (12 A s), can't naively be encoded as "12A" . since this string can be decoded as either "AAAAAAAAAAAA" or
   "IAA" . Thus, long runs (runs of 10 or more characters) should be encoded in a split fashion; the aforementioned run should be
   encoded as "9A3A"

    Sample Input: AAAAAAAAAAAAABBCCCCDD
    Expected output: 9A4A2B4C2D
 */
public static class RunLengthEncoding
{
    // O(n) time I O(n) space - where n is the length of the input string
    public static string RunLengthEncodingFast(string str)
    {
        var previous = str[0];
        var sb = new StringBuilder();
        var count = 0;
        foreach (var c in str)
        {
            if (c != previous || count == 9)
            {
                sb.Append(count);
                sb.Append(previous);
                count = 1;
                previous = c;
            }
            else if (previous == c)
            {
                count++;
            }
        }

        sb.Append(count);
        sb.Append(previous);

        return sb.ToString();
    }
}