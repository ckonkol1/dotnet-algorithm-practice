namespace Arrays.Easy;

public static class SortedSquaredArray
{
    //Time = O(NLogN)
    //Space = O(N)
    public static int[] SortedSquaredArraySlow(int[] array)
    {
        var originalList = new List<int>(array);
        var squaredList = originalList.Select(n => n * n).ToList();
        squaredList.Sort();
        return squaredList.ToArray();
    }

    //Time - O(N) - just go through the array once
    //Space - O(N) - need to create a brand new output array
    public static int[] SortedSquaredArrayFast(int[] array)
    {
        var result = new int[array.Length];
        var start = 0;
        var end = array.Length - 1;

        for (var i = array.Length - 1; i >= 0; i--)
        {
            if (Math.Abs(array[start]) >= Math.Abs(array[end]))
            {
                result[i] = array[start] * array[start];
                start++;
            }
            else
            {
                result[i] = array[end] * array[end];
                end--;
            }
        }

        return result;
    }
}