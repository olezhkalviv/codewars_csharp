using System;

namespace CodeWars.CSharp._8kyu.ReversingWordsInAString
{
    // Reversing Words in a String
    // https://www.codewars.com/kata/57a55c8b72292d057b000594
    public class Kata
    {
        public static string Reverse(string text)
        {
            var arr = text.Split(' ');
            Array.Reverse(arr);
            return string.Join(" ", arr);
        }
    }
}
