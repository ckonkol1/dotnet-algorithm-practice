namespace Searching.Easy
{
    /*
     *Find Three Largest Numbers
       Write a function that takes in an array of at least three integers and, without sorting the input array, returns a sorted array of the three
       largest integers in the input array.
       The function should return duplicate integers if necessary: for example. it should return [10, 16, 12] for an input array of [10,5, 9, 10 , 12]

       Sample Input
       array = [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]
       Sample Output: [18, 141, 541]

     */
    public static class ThreeLargestNumbers
    {
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            var largeNumbers = new int[3] { Int32.MinValue, Int32.MinValue, Int32.MinValue };

            foreach (var num in array)
            {
                if (num > largeNumbers[2])
                {
                    largeNumbers[0] = largeNumbers[1];
                    largeNumbers[1] = largeNumbers[2];
                    largeNumbers[2] = num;
                }
                else if (num > largeNumbers[1])
                {
                    largeNumbers[0] = largeNumbers[1];
                    largeNumbers[1] = num;
                }
                else if (num > largeNumbers[0])
                {
                    largeNumbers[0] = num;
                }
            }

            return largeNumbers;
        }
    }
}