using System.Linq;

namespace CodeWars.CSharp._8kyu.WhatIsBetween
{
    // What is between?
    // https://www.codewars.com/kata/55ecd718f46fba02e5000029
    public static class Kata
    {
        public static int[] Between(int a, int b)
        {
            return Enumerable.Range(a, b - a + 1).ToArray();
        }
    }
}
