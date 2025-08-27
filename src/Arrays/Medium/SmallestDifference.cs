namespace Arrays.Medium;

/*
 *Smallest Difference
   Write a function that takes in two non-empty arrays of integers, finds the pair of numbers (one from each array) whose absolute
   difference is closest to zero. and returns an array containing these two numbers, with the number from the first array in the first
   position.
   Note that the absolute difference of two integers is the distance between them on the real number line. For example, the absolute
   difference of -5 and 5 is 10, and the absolute difference of -5 and -4 is 1.
   You can assume that there will only be one pair of numbers with the smallest difference.

    Input:
     {
      "arrayOne": [-1, 5, 10, 20, 28, 3],
      "arrayTwo": [26, 134, 135, 15, 17]
     }

    Output:
     [28, 26]
 */
public static class SmallestDifference
{
    public static int[] SmallestDifferenceFast(int[] arrayOne, int[] arrayTwo)
    {
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);
        var arrayOnePtr = 0;
        var arrayTwoPtr = 0;
        var result = new int[2];
        var minDistance = Int32.MaxValue;

        while (minDistance != 0 && arrayOnePtr < arrayOne.Length && arrayTwoPtr < arrayTwo.Length)
        {
            var difference = Math.Abs(arrayOne[arrayOnePtr] - arrayTwo[arrayTwoPtr]);

            if (difference < minDistance)
            {
                minDistance = difference;
                result[0] = arrayOne[arrayOnePtr];
                result[1] = arrayTwo[arrayTwoPtr];
            }

            if (arrayOne[arrayOnePtr] < arrayTwo[arrayTwoPtr])
            {
                arrayOnePtr++;
            }
            else
            {
                arrayTwoPtr++;
            }
        }

        return result;
    }
}