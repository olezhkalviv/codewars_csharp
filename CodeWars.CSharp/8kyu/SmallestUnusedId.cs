using System.Linq;

namespace CodeWars.CSharp._8kyu.SmallestUnusedId
{
    // Smallest unused ID
    // https://www.codewars.com/kata/smallest-unused-id/csharp
    public class Kata
    {
        public static int NextId(int[] ids)
        {
            int index = 0;
            for (int i = 0; i <= ids.Length; i++)
            {
                if (!ids.Any(id => id == i))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
