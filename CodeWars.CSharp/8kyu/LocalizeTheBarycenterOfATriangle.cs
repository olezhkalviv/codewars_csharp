using System;

namespace CodeWars.CSharp._8kyu.LocalizeTheBarycenterOfATriangle
{
    // LocalizeTheBarycenterOfATriangle
    // https://www.codewars.com/kata/localize-the-barycenter-of-a-triangle/csharp
    public class Barycenter
    {
        public static double[] BarTriang(double[] a, double[] b, double[] c)
        {
            var x = Math.Round(((a[0] + b[0] + c[0]) / 3), 4);
            var y = Math.Round(((a[1] + b[1] + c[1]) / 3), 4);
            return new[] {x, y};
        }
    }
}