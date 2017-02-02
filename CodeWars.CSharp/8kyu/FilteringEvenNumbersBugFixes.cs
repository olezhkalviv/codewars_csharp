using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CSharp._8kyu.FilteringEvenNumbersBugFixes
{
    // Filtering even numbers (Bug Fixes)
    // https://www.codewars.com/kata/566dc566f6ea9a14b500007b
    public class Kata
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            return listOfNumbers.Where(n => n % 2 == 1).ToList();
        }
    }
}
