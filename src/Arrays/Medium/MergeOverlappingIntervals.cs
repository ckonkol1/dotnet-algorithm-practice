namespace Arrays.Medium;

/*
 *Merge Overlapping Intervals
   Write a function that takes in a non-empty array of arbitrary intervals, merges any overlapping intervals, and returns the new intervals in
   no particular order.
   Each interval is an array of two integers, with interval [6] as the start of the interval and interval [1] as the end of the interval.
   Note that back-to-back intervals aren't considered to be overlapping. For example [1, 5] and [6, 7] aren't overlapping; however,
   [1, 6] and [6, 7] are indeed overlapping.
   Also note that the start of any particular interval will always be less than or equal to the end of that interval.

    Sample Input:  intervals = [[1, 2], [3, 5], [4, 7], [6, 8], [9, 10]]
    Sample Output: [[1, 2], [3, 8], [9, 10]] // the intervals could be ordered differently

    O(n log(n)) time | O(n) space - where n is the number of intervals
 */
public static class MergeOverlappingIntervals
{
    public static int[][] GetMergeOverlappingIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var mergedIntervals = new List<int[]>();
        var currentInterval = intervals[0];
        mergedIntervals.Add(currentInterval);

        foreach (var nextInterval in intervals)
        {
            var currentEnd = currentInterval[1];
            var nextStart = nextInterval[0];
            var nextEnd = nextInterval[1];

            if (currentEnd >= nextStart)
            {
                currentInterval[1] = Math.Max(currentEnd, nextEnd);
            }
            else
            {
                currentInterval = nextInterval;
                mergedIntervals.Add(currentInterval);
            }
        }

        return mergedIntervals.ToArray();
    }
}