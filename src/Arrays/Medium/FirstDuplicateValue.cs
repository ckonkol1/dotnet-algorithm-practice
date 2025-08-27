namespace Arrays.Medium;

/*
 *First Duplicate Value
   Given an array of integers between 1 and n , inclusive, where n is the length of the array, write a function that returns the first
   integer that appears more than once (when the array is read from left to right).
   In other words. out of all the integers that might occur more than once in the input array, your function should retum the one whose
   first duplicate value has the minimum index.
   If no integer appears more than once, your function should return -1 .
   Note that you're allowed to mutate the input array.

   Sample Input:  "array": [2, 1, 5, 2, 3, 3, 4]
   Expected output: 2
 */

public static class FirstDuplicateValue
{
    public static int FirstDuplicateValueSlow(int[] array)
    {
        var maxIndex = Int32.MaxValue;
        var result = -1;

        if (array.Length < 2)
        {
            return result;
        }

        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j] && j < maxIndex)
                {
                    result = array[i];
                    maxIndex = j;
                }
            }
        }

        return result;
    }

    public static int FirstDuplicateValueWithDictionary(int[] array)
    {
        var seen = new Dictionary<int, bool>();
        foreach (var t in array)
        {
            if (seen.ContainsKey(t))
            {
                return t;
            }

            seen.TryAdd(t, true);
        }

        return -1;
    }
}