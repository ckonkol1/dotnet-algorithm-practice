namespace Arrays.Medium;

/*
 *Move Element To End e
   You're given an array of integers and an integer. Write a function that moves all instances of that integer in
   the array to the end of the array and returns the array.
   The function should perform this in place (i.e., it should mutate the input array) and doesn't need to maintain
   the order of the other integers.

    Sample Input:
    {
        "array": [2, 1, 2, 2, 2, 3, 4, 2],
        "toMove": 2
    }

    Expected Output:
        [4, 1, 3, 2, 2, 2, 2, 2]
 */
public static class MoveElementToEnd
{
    public static List<int> MoveElementToEndFast(List<int> array, int toMove)
    {
        var start = 0;
        var end = array.Count - 1;
        while (start < end)
        {
            if (array[start] != toMove)
            {
                start++;
            }
            else if (array[end] == toMove)
            {
                end--;
            }
            else
            {
                array[start] = array[end];
                array[end] = toMove;
                start++;
                end--;
            }
        }

        return array;
    }
}