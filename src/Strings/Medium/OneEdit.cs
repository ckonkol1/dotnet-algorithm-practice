namespace Strings.Medium;

/*
 *One Edit
   You're given two strings stringOne and stringTwo . Write a function that determines if these two strings can be made equal using
   only one edit.

   There are 3 possible edits:
   • Replace: One character in one string is swapped for a different character.
   • Add: One character is added at any index in one string.
   • Remove: One character is removed at any index in one string.
   Note that both strings will contain at least one character. If the strings are the same, your function should return true.

    Sample Input: stringOne = "abc", stringTwo = "ab"
    Sample Output: true // we can remove "c" from stringOne to make it equal to stringTwo
    O(n) time | O(1) space - where n is the length of the shorter string
 */
public static class OneEdit
{
    public static bool GetOneEdit(string stringOne, string stringTwo)
    {
        if (stringOne.Length < stringTwo.Length)
        {
            return GetOneEdit(stringTwo, stringOne);
        }

        if (Math.Abs(stringOne.Length - stringTwo.Length) > 1)
        {
            return false;
        }

        var madeEdit = false;
        var indexOne = 0;
        var indexTwo = 0;

        while (indexOne < stringOne.Length && indexTwo < stringTwo.Length)
        {
            if (stringOne[indexOne] != stringTwo[indexTwo])
            {
                if (madeEdit)
                {
                    return false;
                }

                madeEdit = true;

                if (stringOne.Length == stringTwo.Length)
                {
                    indexOne++;
                    indexTwo++;
                }
                else
                {
                    indexOne++;
                }
            }
            else
            {
                indexOne++;
                indexTwo++;
            }
        }

        return true;
    }
}