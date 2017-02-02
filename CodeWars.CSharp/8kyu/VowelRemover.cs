using System;
using System.Linq;

namespace CodeWars.CSharp._8kyu.VowelRemover
{
    // Vowel remover
    // https://www.codewars.com/kata/5547929140907378f9000039
    public class Kata
    {
        public static string Shortcut(string input)
        {
            char[] vowels = { 'o', 'a', 'e', 'i', 'u' };
            return string.Concat(input.Where(c => Array.IndexOf(vowels, c) == -1));
        }
    }
}
