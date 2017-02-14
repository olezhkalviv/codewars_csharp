using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.CSharp._8kyu.RemovingElements
{
    // Removing Elements
    // https://www.codewars.com/kata/removing-elements
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr.Where((x, i) => { return i % 2 == 0; }).ToArray();
        }
    }
}
