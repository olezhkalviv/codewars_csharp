using System;

namespace CodeWars.CSharp._8kyu.AreYouPlayingBanjo
{
    // Are You Playing Banjo?
    // https://www.codewars.com/kata/53af2b8861023f1d88000832
    public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            return name + (Char.ToLower(name[0]) == 'r' ? " plays" : " does not play") + " banjo";
        }
    }
}
