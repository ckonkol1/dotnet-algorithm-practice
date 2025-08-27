namespace Strings.Easy;

/*
 *Gaesar Cipher Encryptor
   Given a non-empty string of lowercase letters and a non-negative integer representing a key, write a function that returns a new string
   obtained by shifting every letter in the input string by k positions in the alphabet where k is the key.
   Note that letters should "wrap" around the alphabet; in other words, the letter z shifted by one returns the letter a.

    Sample Input:
     {
        "key": 2,
        "string": "xyz"
     }
    Expected output: zab
 */
public static class CaesarCypherEncryptor
{
    public static string CaesarCypherEncryptorFast(string str, int key)
    {
        var result = string.Empty;
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        foreach (var c in str)
        {
            result += alphabet[(alphabet.IndexOf(c) + key) % 26];
        }

        return result;
    }
}