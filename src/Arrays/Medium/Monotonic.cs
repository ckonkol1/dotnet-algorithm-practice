namespace Arrays.Medium;

/*
 *Monotonic Array
   Write a function that takes in an array of integers and returns a boolean representing whether the array is monotonic.
   An array is said to be monotonic if its elements, from left to right, are entirely non-increasing or entirely non-decreasing.
   Non-increasing elements aren't necessarily exclusively decreasing they simply don't increase. Similarly, non-decreasing elements aren't
   necessarily exclusively increasing; they simply don't decrease.
   Note that empty arrays and arrays of one element are monotonic.

    Sample input: "array": [-1, -5, -10, -1100, -1100, -1101, -1102, -9001]
    Result: true

 */
public static class Monotonic
{
    public static bool IsMonotonic(int[] array)
    {
        var increasingResult = true;
        var decreasingResult = true;

        if (array.Length == 0 || array.Length == 1)
        {
            return true;
        }

        for (var i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                increasingResult = false;
            }

            if (array[i] > array[i - 1])
            {
                decreasingResult = false;
            }
        }

        return increasingResult || decreasingResult;
    }
}