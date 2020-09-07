using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HighScore
{
    class HighScoreIO
    {


        public static void WriteToFile(List<HighScore>  highscorelist)
        {
            File.Delete ("highscore.txt");
            foreach (HighScore item in highscorelist)
            {
                string formattet = string.Format("{0} = {1}\n", item.Name, item.Score);
                File.AppendAllText("highscore.txt", formattet);
                
            }
        }
        public static void ReadFromFile(List<HighScore> highscorelist)
        {
            if (File.Exists("highscore.txt") == false)
            {
                return;
            }
            string highscoreTxt = File.ReadAllText("highscore.txt");
            highscoreTxt = highscoreTxt.Trim();
            string [] lines = highscoreTxt.Split("\n");


            foreach (string item in lines)
            {
                if (item == "")
                {
                    continue;
                }
                string[] newLines = item.Split("=");
                HighScore h = new HighScore();
                h.Name = newLines[0];
                h.Score = int.Parse(newLines[1]);
                highscorelist.Add(h);
                highscorelist.Sort(new HighScore());
            }
        }
    }
}
