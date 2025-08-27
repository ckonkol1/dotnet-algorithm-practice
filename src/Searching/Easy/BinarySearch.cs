namespace Searching.Easy;

public static class BinarySearch
{
    /*
     *Binary Search
       Write a function that takes in a sorted array of integers as well as a target integer. The function should use the Binary Search algorithm
       to determine if the target integer is contained in the array and should return its index if it is, otherwise -1 .

       Sample Input: array = [3, 5, 21,33,45,45,61,71,72, 73]
                     target = 33
       Sample Output = 3
     */
    public static int BinarySearchFast(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;
        var middle = right / 2;

        while (left <= right)
        {
            if (array[middle] == target)
            {
                return middle;
            }
            else if (target > array[middle])
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }

            middle = (right + left) / 2;
        }

        return -1;
    }
}