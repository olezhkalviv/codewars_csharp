﻿namespace CodeWars.CSharp._8kyu.RockPaperScissors
{
    // Rock Paper Scissors!
    // https://www.codewars.com/kata/rock-paper-scissors/csharp
    public class Kata
    {
        public string Rps(string p1, string p2)
        {
            return (p1 == p2)
                ? "Draw!"
                : ((p1 == "scissors" && p2 == "paper") || (p1 == "paper" && p2 == "rock") || (p1 == "rock" && p2 == "scissors"))
                    ? "Player 1 won!"
                    : "Player 2 won!";
        }
    }
}
