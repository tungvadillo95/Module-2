using System;

namespace RefactoringTennisGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = TennisGame.GetScore("Isner", "Nadal", 0, 2);
            Console.WriteLine(result);
        }
    }
}
