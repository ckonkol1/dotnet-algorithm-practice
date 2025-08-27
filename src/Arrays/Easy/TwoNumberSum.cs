namespace Arrays.Easy;

/*
// Two Number Sum
//  Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum.If any two numbers in the
//  input array sum up to the target sum, the function should return them in an array, in any order. If no two numbers sum up to the target
//  sum, the function should return an empty array.
//  Note that the target sum has to be obtained by summing two different integers in the array; you can't add a single integer to itself in
//  order to obtain the target sum.
//  You can assume that there will be at most one pair of numbers summing up to the target sum.
//
//  Sample Input:
//    array = [3, 5, -4, 8, 11, 1, -1, 6]
//    targetSum: 10
//
//  Example Output:
//    [-1, 11]
*/
public class TwoNumberSum
{
    //Time - O(N^2)
    //Space - O(N)
    public static int[] TwoNumberSumArray(int[] array, int targetSum)
    {
        var list = new List<int>();
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == targetSum)
                {
                    list.Add(array[i]);
                    list.Add(array[j]);
                }
            }
        }

        return list.ToArray();
    }

    public static int[] TwoNumberSumDictionary(int[] array, int targetSum)
    {
        // Time O(N), Space O(N)
        var dict = new Dictionary<int, bool>();
        foreach (var x in array)
        {
            var y = targetSum - x;
            if (dict.ContainsKey(y))
            {
                return [x, y];
            }

            dict.TryAdd(x, true);
        }

        return [];
    }
}