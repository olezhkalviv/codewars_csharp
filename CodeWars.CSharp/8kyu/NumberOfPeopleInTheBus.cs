using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CSharp._8kyu
{
    // Number of People in the Bus
    // https://www.codewars.com/kata/5648b12ce68d9daa6b000099
    public class NumberOfPeopleInTheBus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(x => x[0] - x[1]);
        }
    }
}
