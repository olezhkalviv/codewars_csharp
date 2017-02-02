using System;
using System.Linq;

namespace CodeWars.CSharp._8kyu.FakeBinary
{
    // Fake Binary
    // https://www.codewars.com/kata/57eae65a4321032ce000002d
    public class Kata
    {
        public static string FakeBin(string x)
        {
            return string.Concat(x.Select(c => Int32.Parse(c.ToString()) < 5 ? 0 : 1));
        }
    }
}
