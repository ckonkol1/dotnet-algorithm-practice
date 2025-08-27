namespace Arrays.Medium;

/*
 *Spiral Traverse
   Write a function that takes in an n x m two-dimensional array (that can be square-shaped when n m) and returns a
   one-dimensional array of all the array's elements in spiral order.
   Spiral order starts at the top left corner of the two-dimensional array, goes to the right, and proceeds in a spiral pattern
   all the way until every element has been visited.

    Sample Input:
        {
         "array": [
           [1, 2, 3, 4],
           [12, 13, 14, 5],
           [11, 16, 15, 6],
           [10, 9, 8, 7]
         ]
        }

    Expected Output:
        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }
 */
public static class SpiralTraverse
{
    public static List<int> SpiralTraverseIterative(int[,] array)
    {
        var result = new List<int>();
        var startingRow = 0;
        var endingRow = array.GetLength(0) - 1;
        var startingColumn = 0;
        var endingColumn = array.GetLength(1) - 1;

        while (startingRow <= endingRow && startingColumn <= endingColumn)
        {
            for (var i = startingColumn; i <= endingColumn; i++)
            {
                result.Add(array[startingRow, i]);
            }

            for (var i = startingRow + 1; i <= endingRow; i++)
            {
                result.Add(array[i, endingColumn]);
            }

            for (var i = endingColumn - 1; i >= startingColumn && endingRow > startingRow; i--)
            {
                result.Add(array[endingRow, i]);
            }

            for (var i = endingRow - 1; i >= startingRow + 1 && endingColumn > startingColumn; i--)
            {
                result.Add(array[i, startingColumn]);
            }

            startingRow++;
            startingColumn++;
            endingColumn--;
            endingRow--;
        }

        return result;
    }

    public static List<int> SpiralTraverseRecursive(int[,] array)
    {
        var result = new List<int>();
        var startingRow = 0;
        var endingRow = array.GetLength(0) - 1;
        var startingColumn = 0;
        var endingColumn = array.GetLength(1) - 1;

        while (startingRow <= endingRow && startingColumn <= endingColumn)
        {
            for (var i = startingColumn; i <= endingColumn; i++)
            {
                result.Add(array[startingRow, i]);
            }

            for (var i = startingRow + 1; i <= endingRow; i++)
            {
                result.Add(array[i, endingColumn]);
            }

            for (var i = endingColumn - 1; i >= startingColumn && endingRow > startingRow; i--)
            {
                result.Add(array[endingRow, i]);
            }

            for (var i = endingRow - 1; i >= startingRow + 1 && endingColumn > startingColumn; i--)
            {
                result.Add(array[i, startingColumn]);
            }

            startingRow++;
            startingColumn++;
            endingColumn--;
            endingRow--;
        }

        return result;
    }
}