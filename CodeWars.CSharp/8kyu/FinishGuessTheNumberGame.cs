using System;

namespace CodeWars.CSharp._8kyu.FinishGuessTheNumberGame
{
    // Finish Guess the Number Game
    // https://www.codewars.com/kata/finish-guess-the-number-game
    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives == 0) throw new Exception();
            return n == number ? true : new Func<bool>(() => { lives--; return false; })();
        }
    }
}
