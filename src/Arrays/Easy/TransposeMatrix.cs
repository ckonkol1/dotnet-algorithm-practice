namespace Arrays.Easy;

/*
 *Transpose Matrix
   You're given a 2D array of integers matrix . Write a function that returns the transpose of the matrix.
   The transpose of a matrix is a flipped version of the original matrix across its main diagonal (which runs from top-left to
   bottom-right); it switches the row and column indices of the original matrix.
   You can assume the input matrix always has at least I value; however its width and height are not necessarily the same.

    Sample Input:
        matrix = [
            [1,2],
            [3,4],
            [5,6]
        ]

    Sample Output:
         matrix = [
           [1,3,5],
           [2,4,6]
        ]

    Hint: The row and column indices of each entry in the matrix should be flipped. For example, the value at
   matrix [1][2] will be at matrix [2][1] in the transpose of the matrix.
 */
public static class TransposeMatrix
{
    public static int[,] TransposeMatrixFast(int[,] matrix)
    {
        var rows = matrix.GetLength(0);
        var columns = matrix.GetLength(1);
        var result = new int[columns, rows];

        for (var i = 0; i < columns; i++)
        {
            for (var j = 0; j < rows; j++)
            {
                result[i, j] = matrix[j, i];
            }
        }

        return result;
    }
}