using System.Linq;

namespace CodeWars.CSharp._8kyu.CalculateAverage
{
    // Calculate average
    // https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            return (array.Length == 0) ? 0 : array.Average();
        }
    }
}
