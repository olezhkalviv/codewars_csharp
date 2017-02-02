namespace CodeWars.CSharp._8kyu
{
    // Pre-FizzBuzz Workout #1
    // https://www.codewars.com/kata/569e09850a8e371ab200000b
    public class PreFizzBuzzWorkout1
    {
        public static int[] PreFizz(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = i + 1;
            return arr;
        }
    }
}
