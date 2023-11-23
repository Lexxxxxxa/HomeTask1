using System;

namespace HomeTask4
{
    public class Game21
    {
        private CardDeck deck;
        private Player player;
        private Player computer;

        public Game21()
        {
            deck = new CardDeck();
            player = new Player();
            computer = new Player();
        }

        public string PlayRound()
        {
            Console.WriteLine("Welcome to 'Game21'! :-]");
            Console.ReadLine();

            InitializeRound();

            Console.WriteLine($"Your Cards {deck.Cards[0]}, {deck.Cards[2]} (Total points {player.CalculateScore()})");

            int currentIndex = 3; 

            while (AskForAnotherCard())
            {
                int playerPoints = (int)deck.Cards[++currentIndex].Rank;
                player.AddCard(deck.Cards[currentIndex]);
                Console.WriteLine($"You get {deck.Cards[currentIndex]}  (Total points {player.CalculateScore()})");
                Console.WriteLine();

                if (player.CalculateScore() == 21)
                {
                    Console.WriteLine("You got 21! You win! ]:->");
                    return "Player";
                }
                else if (player.CalculateScore() > 21)
                {
                    Console.WriteLine("Computer wins! -_-");
                    return "Computer";
                }
            }

            while (computer.CalculateScore() <= 16)
            {
                int computerPoints = (int)deck.Cards[++currentIndex].Rank;
                computer.AddCard(deck.Cards[currentIndex]);
            }

            if (computer.CalculateScore() > 21)
            {
                Console.WriteLine($"You win! =D Computer score {computer.CalculateScore()}");
                return "Player";
            }
            else if (computer.CalculateScore() == 21 || computer.CalculateScore() > player.CalculateScore())
            {
                Console.WriteLine($"Computer wins! о_О Computer score {computer.CalculateScore()}");
                return "Computer";
            }
            else if (player.CalculateScore() > computer.CalculateScore())
            {
                Console.WriteLine($"You win! =) Computer score {computer.CalculateScore()}");
                return "Player";
            }
            else
            {
                Console.WriteLine($"It's a draw! \\_(?)_/ Computer score {computer.CalculateScore()}");
                return "";
            }
        }

        private void InitializeRound()
        {
            deck.ShuffleDeck();
            player.ClearHand();
            computer.ClearHand();

            for (int i = 0; i < 4; i += 2)
            {
                player.AddCard(deck.Cards[i]);
                computer.AddCard(deck.Cards[i + 1]);
            }
        }

        private bool AskForAnotherCard()
        {
            Console.WriteLine("Do you want another card? (y/n)");
            string response = Console.ReadLine().ToLower();
            return response == "y";
        }
    }
}