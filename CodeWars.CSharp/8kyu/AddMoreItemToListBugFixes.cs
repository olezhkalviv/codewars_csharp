using System.Collections.Generic;

namespace CodeWars.CSharp._8kyu.AddMoreItemToListBugFixes
{
    // Add more item to list (Bug Fixes)
    // https://www.codewars.com/kata/add-more-item-to-list-bug-fixes
    public class AddMore
    {
        public static List<int> AddExtra(List<int> listOfNumbers)
        {
            List<int> res = new List<int>(listOfNumbers);
            res.Add(9);
            return res;
        }
    }
}
