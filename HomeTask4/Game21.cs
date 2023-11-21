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

            deck.ShuffleDeck();
            player.ResetPoints();
            computer.ResetPoints();

            int temp = 0;
            while (temp < 4)
            {
                player.AddPoints((int)deck.cards[temp].Rank);
                computer.AddPoints((int)deck.cards[temp + 1].Rank);
                temp += 2;
            }

            Console.WriteLine($"Your cards {deck.cards[0]}, {deck.cards[2]} (Total points {player.Points})");
            //Console.WriteLine($"Your cards {deck.cards[1]}, {deck.cards[3]} (Total points {computer.Points})");

            while (true)
            {
                Console.WriteLine("Do you want another card? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                    break;

                int playerPoints = (int)deck.cards[++temp].Rank;
                player.AddPoints(playerPoints);
                Console.WriteLine($"You get {deck.cards[temp]}  (Total points {player.Points})");
                Console.WriteLine();

                if (player.Points == 21)
                {
                    Console.WriteLine("You got 21! You win! ]:->");
                    return "Player";
                }
                else if (player.Points > 21)
                {
                    Console.WriteLine("Computer wins! -_-");
                    return "Computer";
                }
            }

            while (computer.Points <= 16)
            {
                int computerPoints = (int)deck.cards[++temp].Rank;
                computer.AddPoints(computerPoints);
                //Console.WriteLine($"You get {deck.cards[temp]} (Total points {computer.Points})");
            }

            if (computer.Points > 21)
            {
                Console.WriteLine($"You win! =D Computer score {computer.Points}");
                return "Player";
            }
            else if (computer.Points == 21 || computer.Points > player.Points)
            {
                Console.WriteLine($"Computer wins! о_О Computer score {computer.Points}");
                return "Computer";
            }
            else if (player.Points > computer.Points)
            {
                Console.WriteLine($"You win! =) Computer score {computer.Points}");
                return "Player";
            }
            else
            {
                Console.WriteLine($"It's a draw! \\_(?)_/ Computer score {computer.Points}");
                return "";
            }
        }
    }
}