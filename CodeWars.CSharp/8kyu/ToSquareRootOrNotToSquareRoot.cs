using System;
using System.Linq;

namespace CodeWars.CSharp._8kyu.ToSquareRootOrNotToSquareRoot
{
    // To square(root) or not to square(root)
    // https://www.codewars.com/kata/57f6ad55cca6e045d2000627
    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            return array.Select(x => Convert.ToInt32(Math.Sqrt(x) - Math.Floor(Math.Sqrt(x)) > 0 ? Math.Pow(x, 2) : Math.Sqrt(x))).ToArray();
        }
    }
}
