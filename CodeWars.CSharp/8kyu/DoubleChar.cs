using System.Linq;

namespace CodeWars.CSharp._8kyu
{
    // Double Char
    // https://www.codewars.com/kata/56b1f01c247c01db92000076
    public class DoubleCharClass
    {
        public static string DoubleChar(string s)
        {
            return string.Concat(s.Select(c => c.ToString() + c.ToString()));
        }
    }
}
