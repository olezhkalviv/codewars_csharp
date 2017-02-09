using System.Linq;

namespace CodeWars.CSharp._8kyu.TakeAnArrowToTheKneeFunctionally
{
    // This class is added to avoid errors, as Tools class is described in CodeWars directly, so don't use it.
    public class Tools
    {
        public static string FromCharCode(int c)
        {
            return string.Empty;
        }
    }

    // Take an Arrow to the knee, Functionally
    // https://www.codewars.com/kata/559f3123e66a7204f000009f
    public class Kata
    {
        public static string ArrowFunc(int[] arr)
        {
            return string.Join("", arr.Select(c => Tools.FromCharCode(c)).ToArray());
        }
    }
}
