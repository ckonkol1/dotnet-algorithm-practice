namespace Sorting.Easy;

public static class BubbleSort
{
    /*
     *Bubble Sort
       Write a function that takes in an array of integers and returns a sorted version of that array. Use the Bubble Sort algorithm to sort
       the array.

       Sample Input:  "array": [8, 5, 2, 9, 5, 6, 3]
       Sample Output: [2, 3, 5, 5, 6, 8, 9]

       Space and Time Complexity: O(n) time | O(1) space
     */
    public static int[] PerformBubbleSort(int[] array)
    {
        var isSorted = false;
        var counter = 1;
        while (!isSorted)
        {
            isSorted = true;
            for (var i = 0; i < array.Length - counter; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    isSorted = false;
                }
            }

            counter++;
        }

        return array;
    }
}