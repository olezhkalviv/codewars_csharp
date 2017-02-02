using System.Linq;

namespace CodeWars.CSharp._8kyu.StringRepeat
{
    // String repeat
    // https://www.codewars.com/kata/57a0e5c372292dd76d000d7e
    public static class Program
    {
        public static string repeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
