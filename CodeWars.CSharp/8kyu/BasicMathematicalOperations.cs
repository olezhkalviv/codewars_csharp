namespace CodeWars.CSharp._8kyu
{
    // Basic Mathematical Operations
    // https://www.codewars.com/kata/57356c55867b9b7a60000bd7
    public class BasicMathematicalOperations
    {
        public static double basicOp(char op, double val1, double val2)
        {
            switch (op)
            {
                case '+':
                    return val1 + val2;
                case '-':
                    return val1 - val2;
                case '*':
                    return val1 * val2;
                case '/':
                    return val1 / val2;
                default:
                    return 0;
            }
        }
    }
}
