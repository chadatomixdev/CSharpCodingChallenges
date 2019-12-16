using System;
namespace StringManipulation
{
    public static class StringManipulation
    {
        //Write a method to reverse a string
        public static string ReverseString(string originalString)
        {
            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Write a function that determines if a string starts with an upper-case letter A-Z
        public static Case ReturnStringCase(string originalString)
        {
            var firstChar = originalString[0];

            if (char.IsUpper(firstChar))
                return Case.Uppercase;
            if (char.IsLower(firstChar))
                return Case.Lowercase;

            return Case.Lowercase;
        }

        public enum Case
        {
            Uppercase,
            Lowercase
        }
    }
}