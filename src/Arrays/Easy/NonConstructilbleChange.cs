namespace Arrays.Easy;

public static class NonConstructilbleChange
{
    // that if the coin is less than or equal to our change plus one, we can make all the change previously
    // and then all the change between what we can make previously plus one
    //Time = O(NlogN) (need to sort)
    public static int NonConstructibleChangeFast(int[] coins)
    {
        Array.Sort(coins);

        var change = 0;
        foreach (var coin in coins)
        {
            if (coin <= change + 1)
            {
                change += coin;
            }
            else
            {
                break;
            }
        }

        return change + 1;
    }
}