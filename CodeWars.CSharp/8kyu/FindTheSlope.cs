namespace CodeWars.CSharp._8kyu.FindTheSlope
{
    // Find the Slope
    // https://www.codewars.com/kata/find-the-slope
    public class Slope
    {
        public string slope(int[] points)
        {
            return points[2] == points[0] ? "undefined" : $"{(points[3] - points[1]) / (points[2] - points[0])}";
        }
    }
}
