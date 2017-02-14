using System;

namespace CodeWars.CSharp._8kyu.HowOldWillIBeIn2099
{
    // HowOldWillIBeIn2099
    // https://www.codewars.com/kata/how-old-will-i-be-in-2099
    public static class AgeDiff
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            int diff = Math.Abs(yearTo - birth);
            return yearTo == birth ? "You were born this very year!" : yearTo > birth ? $"You are {diff} year{(diff == 1 ? "" : "s")} old." : $"You will be born in {diff} year{(diff == 1 ? "" : "s")}.";
        }
    }
}