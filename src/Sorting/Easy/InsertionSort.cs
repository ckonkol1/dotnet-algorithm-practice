namespace Sorting.Easy;

public static class InsertionSort
{
    /*
     * Insertion Sort
           Write a function that takes in an array of integers and returns a sorted version of that array. Use the Insertion Sort algorithm to sort the
           array.
           If you're unfamiliar with Insertion Sort. we recommend watching the Conceptual Overview section of this question's video explanation
           before starting to code.

        Sample Input: "array": [8, 5, 2, 9, 5, 6, 3]
        Sample Output: [2, 3, 5, 5, 6, 8, 9]
     */

    public static int[] PreformInsertionSort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var j = i;
            while (j > 0 && array[j] < array[j - 1])
            {
                (array[j], array[j - 1]) = (array[j - 1], array[j]);
                j -= 1;
            }
        }

        return array;
    }
}