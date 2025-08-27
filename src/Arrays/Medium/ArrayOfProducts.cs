namespace Arrays.Medium;

/*
 *Array Of Products
   Write a function that takes in a non-empty array of integers and returns an array of the same length, where each element in the output
   array is equal to the product of every other number in the input array.
   In other words, the value at outputCi] is equal to the product of every number in the input array other than inputCi]
   Note that you're expected to solve this problem without using division.

    Sample Input: "array": [5, 1, 4, 2]
    Expected Output: [8, 40, 10, 20]
        // 8 is equal to 1 x 4 x 2
        // is equal to 5 x 4 x 2
        // 10 is equal to 5 x 1 x 2
        // 2e is equal to 5 x 1 x 4
 *
 */
public static class ArrayOfProducts
{
    //O(N)^2
    public static int[] ArrayOfProductsSlow(int[] array)
    {
        var result = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            var product = 1;
            for (var j = 0; j < array.Length; j++)
            {
                if (i != j)
                {
                    product = product * array[j];
                }
            }

            result[i] = product;
        }

        return result;
    }

    //O(N)
    public static int[] ArrayOfProductsFast(int[] array)
    {
        var product = 1;
        var output = new int[array.Length];

        //first calculate left products
        for (var i = 0; i < array.Length; i++)
        {
            output[i] = product;
            product *= array[i];
        }

        //then multiply the right with the left  
        product = 1;
        for (var i = array.Length - 1; i >= 0; i--)
        {
            output[i] *= product;
            product *= array[i];
        }

        return output;
    }
}