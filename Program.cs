using System;
namespace ROCKPAPERANDSCISSORS {
    class Program 
    {
        static void Main(string[] args) 
        {
            string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
            {

            

            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:   ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt)
            {
                case 1: 
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK") 
                    {
                        Console.WriteLine("Draw!!\n\n");
                    } 
                    else if (inputPlayer == "PAPER") 
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    } 
                    else if (inputPlayer == "SCISSORS") 
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER") 
                    {
                        Console.WriteLine("Draw!!\n\n");
                    } 
                    else if (inputPlayer == "SCISSORS") 
                    { 
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    } 
                    else if (inputPlayer == "ROCK") 
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS") 
                    {
                        Console.WriteLine("Draw!!\n\n");
                    } 
                    else if (inputPlayer == "ROCK") 
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    } 
                    else if (inputPlayer == "PAPER") 
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry!");
                    break;
            }

            Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);

        }
        if (scorePlayer == 3)
        {
            Console.WriteLine("Player WON!");
        }
        else if (scoreCPU == 3)
        {
            Console.WriteLine("Player WON!");

        }
        else
        {
            
        }
        Console.WriteLine("Do you want to play again?(Y/N)");
        string loop = Console.ReadLine();
        if (loop == "Y")
        {
            playAgain = true;
            Console.Clear();
        }
        else if (loop == "N")
        {
            playAgain =false;
        }
        else 
        {

        }
        }
    }
    }
}