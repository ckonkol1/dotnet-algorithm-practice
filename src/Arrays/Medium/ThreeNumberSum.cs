namespace Arrays.Medium;

/*
 * Three Number Sum
 *  Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. The function should find
 *  all triplets in the array that sum up to the target sum and return a two-dimensional array of all these triplets. The numbers in each
 *  triplet should be ordered in ascending order, and the triplets themselves should be ordered in ascending order with respect to the
 *  numbers they hold.
 *  If no three numbers sum up to the target sum. the function should return an empty array.
 *
 *  Sample Input:
    {
      "array": [12, 3, 1, 2, -6, 5, -8, 6],
      "targetSum": 0
    }

 *  Expected Output:
      [
         [-8, 2, 6],
         [-8, 3, 5],
         [-6, 1, 5]
      ]
 */
public static class ThreeNumberSum
{
    //O(nA2) time I O(n) space - where n is the length of the input array
    public static List<int[]> ThreeNumberSumFast(int[] array, int targetSum)
    {
        var list = new List<int[]>();
        Array.Sort(array);

        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] > targetSum)
            {
                break;
            }

            var left = i + 1;
            var right = array.Length - 1;
            while (left < right)
            {
                var currentSum = array[i] + array[left] + array[right];
                //Move both pointers
                if (currentSum == targetSum)
                {
                    list.Add([array[i], array[left], array[right]]);
                    left++;
                    right--;
                }
                //if the currentSum is greater than the target sum, then we want to
                //decrease the third number value to get a lower sum on the next loop 
                else if (currentSum > targetSum)
                {
                    right--;
                }
                //if the currentSum is less than the target sum, then we want to
                //increase the second number value to get a higher sum on the next loop 
                else
                {
                    left++;
                }
            }
        }

        return list;
    }
}