using System.Numerics;

namespace CodeWars.CSharp._8kyu
{
    // Powers of 2
    // https://www.codewars.com/kata/57a083a57cb1f31db7000028
    public class PowersOf2
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] arr = new BigInteger[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                arr[i] = BigInteger.Pow(2, i);
            }
            return arr;
        }
    }
}
