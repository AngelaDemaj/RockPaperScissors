using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> choices = new List<string>
            {
                "Rock",
                "Paper",
                "Scissors"
            };

            var random = new Random();
            var computerChoice = choices[random.Next(0, 3)];

            Console.WriteLine("Choose: Rock, Paper, Scissors");
            var playerChoice = ValidateChoice(choices);

            Console.WriteLine($"Computer chose {computerChoice}");

            if (computerChoice == playerChoice)
            {
                Console.WriteLine("It's a tie!");
            }

            else if (computerChoice == "Rock")
            {
                if (playerChoice == "Paper")
                {
                    Console.WriteLine("You win!");
                }

                else
                {
                    Console.WriteLine("You lose!");
                }
            }

            else if (computerChoice == "Paper")
            {
                if (playerChoice == "Scissors")
                {
                    Console.WriteLine("You win!");
                }

                else
                {
                    Console.WriteLine("You lose!");
                }
            }

            else
            {
                if (playerChoice == "Rock")
                {
                    Console.WriteLine("You win!");
                }

                else
                {
                    Console.WriteLine("You lose!");
                }
            }
        }

        static string ValidateChoice(List<string> choices)
        {
            var userInput = Console.ReadLine();
            while (!choices.Contains(userInput))
            {
                Console.WriteLine("Wrong choice");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }
}
