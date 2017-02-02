using System.Linq;

namespace CodeWars.CSharp._8kyu.CountByX
{
    // Count by X
    // https://www.codewars.com/kata/5513795bd3fafb56c200049e
    public static class Kata
    {
        public static int[] CountBy(int x, int n)
        {
            return Enumerable.Range(1, n).Select(v => v * x).ToArray();
        }
    }
}
