using System;
using System.Collections.Generic;

namespace HighScore
{
    class Program
    {

        static HighScore enterHighscore()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            HighScore highscore = new HighScore();
            highscore.Name = name;
            highscore.Score = score;
            return highscore;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Highscore!");
            int count = 0;

            List<HighScore> highscoreList = new List<HighScore>();
            HighScoreIO.ReadFromFile(highscoreList);
            foreach (HighScore item in highscoreList)
            {
                string formattet = string.Format("{0} {1}", item.Name, item.Score);
                count++;
                if (count <= 5)
                {
                    Console.WriteLine(formattet);
                }
            }
            
            for (int i = 0; i < 3; i++)
            {
                HighScore benjaminTheWise = enterHighscore();
                highscoreList.Add(benjaminTheWise);
                Console.WriteLine("Highscore: " + benjaminTheWise.Name);
            }
            HighScoreIO.WriteToFile(highscoreList);
        }
    }
}
