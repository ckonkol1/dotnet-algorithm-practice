/*
 *Write a function that takes in a non-empty array of integers and returns the maximum sum that can be obtained by summing up all of
   the integers in a non-empty subarray of the input array. A subarray must only contain adjacent numbers (numbers next to each other in
   the input array).

    Sample Input:  array = [3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3]
    Sample Output: 19 // subarray = [1, 3, -2, 3, 4, 7, 2]

    O(n) time | O(1) space - where n is the length of the input array
 */

public static class KadanesAlgorithm
{
    public static int GetKadanesAlgorithm(int[] array)
    {
        var currentMaxValue = array[0];
        var maxEndingValue = array[0];
        for (var i = 1; i < array.Length; i++)
        {
            maxEndingValue = Math.Max(maxEndingValue + array[i], array[i]);
            currentMaxValue = Math.Max(maxEndingValue, currentMaxValue);
        }

        return currentMaxValue;
    }
}