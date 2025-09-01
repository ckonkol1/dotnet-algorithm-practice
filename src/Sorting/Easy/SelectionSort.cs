namespace Sorting.Easy;

/*
 *Selection Sort
   Write a function that takes in an array of integers and returns a sorted version of that array. Use the Selection Sort algorithm to sort the
   array.

   Sample Input:   array = [8, 5, 2, 9, 5, 6, 3]
   Sample Output: [2, 3, 5, 5, 6, 8, 9]

 */
public static class SelectionSort
{
    //Space Complexity = O(1), Time Complexity = O(N^2)
    public static int[] PerformSelectionSort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var smallest = i;
            for (var j = i; j < array.Length; j++)
            {
                if (array[j] < array[smallest])
                {
                    smallest = j;
                }
            }

            if (smallest != i)
            {
                var temp = array[i];
                array[i] = array[smallest];
                array[smallest] = temp;
            }
        }

        return array;
    }
}