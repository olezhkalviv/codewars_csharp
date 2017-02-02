using System;

namespace CodeWars.CSharp._8kyu.ColorGhost
{
    // Color Ghost
    // https://www.codewars.com/kata/53f1015fa9fe02cbda00111a
    public class Ghost
    {
        Random rnd = new Random();
        string[] color = { "white", "yellow", "purple", "red" };
        public string GetColor()
        {
            return color[rnd.Next(0, 4)];
        }
    }
}
