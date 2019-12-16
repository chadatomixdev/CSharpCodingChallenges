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
    }
}