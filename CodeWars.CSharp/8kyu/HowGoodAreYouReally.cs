using System.Linq;

namespace CodeWars.CSharp._8kyu.HowGoodAreYouReally
{
    // How good are you really?
    // https://www.codewars.com/kata/how-good-are-you-really
    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > ClassPoints.Average();
        }
    }
}
