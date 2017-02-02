namespace CodeWars.CSharp._8kyu.GrasshopperGradeBook
{
    // Grasshopper - Grade book
    // https://www.codewars.com/kata/55cbd4ba903825f7970000f5
    public class Kata
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            var avg = (s1 + s2 + s3) / 3;
            return avg < 60 ? 'F' : avg < 70 ? 'D' : avg < 80 ? 'C' : avg < 90 ? 'B' : 'A';
        }
    }
}
