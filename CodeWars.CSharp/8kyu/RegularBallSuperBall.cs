namespace CodeWars.CSharp._8kyu.RegularBallSuperBall
{
    // Regular Ball Super Ball
    // https://www.codewars.com/kata/53f0f358b9cb376eca001079
    public class Ball
    {
        public string ballType { get; set; }

        public Ball()
        {
            ballType = "regular";
        }

        public Ball(string ballType)
        {
            this.ballType = ballType;
        }
    }
}
