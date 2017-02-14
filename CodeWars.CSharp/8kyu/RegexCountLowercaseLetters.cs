using System.Text.RegularExpressions;

namespace CodeWars.CSharp._8kyu.RegexCountLowercaseLetters
{
    // Regex count lowercase letters
    // https://www.codewars.com/kata/regex-count-lowercase-letters
    public class Kata
    {
        public static int LowercaseCountCheck(string s)
        {
            // return s.Count(char.IsLower);
            // return Regex.Matches(s, "[a-z]").Count;
            return Regex.Replace(s, @"[^a-z]+", "").Length;
        }
    }
}
