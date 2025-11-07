namespace Arrays.Medium;

/*
 *Best Seat
   You walk into a theatre you're about to see a show in. The usher within the theatre walks you to your row and mentions you're allowed
   to sit anywhere within the given row. Naturally you'd like to sit in the seat that gives you the most space. You also would prefer this
   space to be evenly distributed on either side of you (e.g. if there are three empty seats in a row, you would prefer to sit in the middle of
   those three seats).
   Given the theatre row represented as an integer array, return the seat index of where you should sit. Ones represent occupied seats
   and zeroes represent empty seats.
   You may assume that someone is always sitting in the first and last seat of the row. Whenever there are two equally good seats. you
   should sit in the seat with the lower index. If there is no seat to sit in. return -1. The given array will always have a length of at least one
   and contain only ones and zeroes.

    Sample Input: seats = [1, 0, 0, 0, 1, 0, 1]
    Sample Output: 2

        O(n) time | O(1) space - where n is the length of the input array
 */
public static class BestSeat
{
    public static int GetBestSeat(int[] seats)
    {
        var bestSeat = -1;
        var maxSpace = 0;

        var left = 0;
        while (left < seats.Length)
        {
            var right = left + 1;
            while (right < seats.Length && seats[right] == 0)
            {
                right++;
            }

            var space = right - left - 1;
            var seatIndex = (right + left) / 2;

            if (space > maxSpace)
            {
                maxSpace = space;
                bestSeat = seatIndex;
            }

            left = right;
        }

        return bestSeat;
    }
}