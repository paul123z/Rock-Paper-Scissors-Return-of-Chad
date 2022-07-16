using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool anotherGame = true;
            string textString;

            string gameAuthor = "Pavol Lantaj";
            string gameVersion = "1.0.1";
            string gameName = "ROCK PAPER SCISSORS: RETURN OF THE CHAD";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}\nVersion {1}\nby Author {2}\n\n",gameName,gameVersion,gameAuthor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WELCOME PLAYER\n");

            while (anotherGame == true) {

                scorePlayer = 0; //we are resettomg the score
                scoreCPU = 0; //we are resettomg the score

                while (scorePlayer < 3 && scoreCPU < 3) {                     
           
            Console.Write("Choose between ROCK,PAPER,SCISSORS: ");
            inputPlayer = Console.ReadLine(); // get input from the person
                inputPlayer = inputPlayer.ToUpper();
                Console.WriteLine("You chose: {0}",inputPlayer);
                    
                while (inputPlayer != "ROCK" && inputPlayer != "PAPER" && inputPlayer != "SCISSORS") {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("INCORRECT INPUT, Please choose between ROCK,PAPER,SCISSORS: ");
                        Console.ForegroundColor = ConsoleColor.White;

                        inputPlayer = Console.ReadLine(); // get input from the person
                    inputPlayer = inputPlayer.ToUpper();
                    Console.WriteLine("You chose: {0}", inputPlayer);

                    }


            Random rnd = new Random();
            randomInt = rnd.Next(1,4); // between 1 and 4 -> 1,2,3

            switch (randomInt) {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose: ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                        
                    {
                        Console.WriteLine("COMPUTER WINS!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose: PAPER");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("COMPUTER WINS!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!\n\n");
                    }
                    else if (inputPlayer == "SCISSORS")
                        
                    {
                        Console.WriteLine("PLAYER WINS!!!\n\n");
                         scorePlayer++;
                    }

                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose: SCISSORS");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("COMPUTER WINS\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS")
                        
                    {
                        Console.WriteLine("DRAW!\n\n");
                        
                    }


                    break;
                default:

                    break;
            
            }
                Console.WriteLine("Player Score: {0}\nCPU Score: {1}\n", scorePlayer, scoreCPU);
        }

            if (scorePlayer == 3)
            {
                Console.WriteLine("PLAYER WON!");
            }
            else if (scoreCPU == 3) {
                Console.WriteLine("CPU WON!");
            }

        Console.WriteLine("Do you want to play another game?\nPlease write Yes or No ");
             textString =   Console.ReadLine();
             textString = textString.ToUpper();
                if (textString == "Yes")
                {
                    anotherGame = true;
                }
                else if (textString == "No")
                {
                    Console.WriteLine("Thank you for playing!");
                    anotherGame = false;
                }
                else {
                    Console.WriteLine("Wrong Input, Bye Amigo");
                    break;
                }

            }
    }
    }
}
