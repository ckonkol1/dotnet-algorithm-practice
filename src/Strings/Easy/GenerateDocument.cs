namespace Strings.Easy
{
    /*
     * Generate Document

    You're given a string of available characters and a string representing a document that you need to generate. Write a function that determines
       if you can generate the document using the available characters. If you can generate the document, your function should return true ;
       otherwise, it should return false.
       You're only able to generate the document if the frequency of unique characters in the characters string is greater than or equal to the
       frequency of unique characters in the document string. For example, if you're given characters
       characters = "abcabc" and document = "aabbccc" you cannot generate the document because you're missing one c.
       The document that you need to create may contain any characters, including special characters, capital letters, numbers, and spaces.
       Note: you can always generate the empty string ""

        Sample Input: characters = "Bste! hetsi ogEAxpelrt x " and  document = "AlgoExpert is the Best!"
        Expected output: true
       x
     */
    public static class GenerateDocument
    {
        public static bool GenerateDocumentFast(string characters, string document)
        {
            var charSet = new Dictionary<char, int>();
            foreach (var c in characters)
            {
                if (!charSet.TryAdd(c, 1))
                {
                    charSet[c]++;
                }
            }

            foreach (var c in document)
            {
                if (charSet.ContainsKey(c) && charSet[c] > 0)
                {
                    charSet[c]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}