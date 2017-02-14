using System.Text.RegularExpressions;

namespace CodeWars.CSharp._8kyu.NoZerosForHeros
{
    // No zeros for heros
    // https://www.codewars.com/kata/no-zeros-for-heros
    public class NoBoring
    {
        public static int NoBoringZeros(int n)
        {
            return n == 0 ? 0 : int.Parse(Regex.Replace(n.ToString(), @"[0]+$", ""));
        }
    }
}
