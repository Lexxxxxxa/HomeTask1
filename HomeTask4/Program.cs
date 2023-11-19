using System;

namespace HomeTask4
{
    internal class Program
    {
        public static void Main()
        {
            //task4.1
            //var deck = new CardDeck();
            //task4.2
            //deck.ShuffleDeck();
            //task4.3
            //deck.ReturnPositionOfAce();
            //task4.4
            //deck.SwitchAllClubsOnBeginning();
            //task4.5
            //deck.SortDeck();
            Console.WriteLine("Welcome to 'Game21'! :-]");
            int playerScore = 0;
            int computerScore = 0;
            int gamesPlayed = 0;
            Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nNew game!");
                int roundWinner = Game21.PlayRound();

                if (roundWinner == 1)
                {
                    playerScore++;
                }
                else if (roundWinner == 2)
                {
                    computerScore++;
                }
                gamesPlayed++;

                Console.WriteLine($"\nPlayer Score {playerScore} \\|/ Computer Score {computerScore}");
                Console.WriteLine($"Total Games Played {gamesPlayed}");
                Console.WriteLine("Do you want to play another round? (y/n)");

                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "y")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}
