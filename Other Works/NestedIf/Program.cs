using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIf
{
    class Program
    {
        static int highscore = 38;
        static string highscorePlayer = "Curtis";
        static void Main(string[] args)
        {
            int playerScore = 200;
            string playerName = "James";
            Console.WriteLine("Playing the game!");
            TheGame(playerScore, playerName);
            Console.Read();

        }
        public static void TheGame(int score, string player)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = player;

                Console.WriteLine("New Highscore is " + score + "!");
                Console.WriteLine("New Highscore holder is " + player + "!");
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
            /*switch(score)
            {
                case  > highscore:
                    Console.WriteLine("New Highscore is " + score + "!");
                    Console.WriteLine("New Highscore holder is " + player + "!");
                        break;
                default:
                    Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
                        break;
                    
            }*/
        }
    }
}
