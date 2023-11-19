using System;

namespace HomeTask4
{
    public class Game21
    {
        public static int PlayRound()
        {
            var deck = new CardDeck();
            deck.ShuffleDeck();
            int playerPoints = 0;
            int computerPoints = 0;

            int temp = 0;
            while (temp < 4)
            {
                playerPoints += GetCardValue(deck.Cards[temp++]);
                computerPoints += GetCardValue(deck.Cards[temp++]);
            }

            Console.WriteLine($"Your cards {deck.Cards[0]}, {deck.Cards[2]} (Total points {playerPoints})");
            //uncomment it to trace the bot's actions
            //Console.WriteLine($"Computer's cards {deck.Cards[1]}, {deck.Cards[3]} (Total points {computerPoints})");

            while (true)
            {
                Console.WriteLine("Do you want another card? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response != "y") 
                    break;

                playerPoints += GetCardValue(deck.Cards[temp]);
                Console.WriteLine($"You get {deck.Cards[temp]}  (Total points {playerPoints})");
                Console.WriteLine();

                if (playerPoints == 21)
                {
                    Console.WriteLine("You got 21! You win! ]:->");
                    return 1;
                }
                else if (playerPoints > 21)
                {
                    Console.WriteLine("Computer wins! -_-");
                    return 2;
                }
            }

            if (temp < deck.Cards.Count)
            {
                computerPoints += GetCardValue(deck.Cards[temp++]);
            }

            //uncomment it to trace the bot's actions
            //Console.WriteLine($"Computer get card {deck.Cards[temp]} (Total points {computerPoints})");

            if (computerPoints > 21)
            {
                Console.WriteLine("You win! =D");
                return 1;
            }
            else if (computerPoints == 21 || computerPoints > playerPoints)
            {
                Console.WriteLine($"Computer wins! о_О Computer score {computerPoints}");
                return 2;
            }
            else if (playerPoints > computerPoints)
            {
                Console.WriteLine($"You win! =) Computer score {computerPoints}");
                return 1;
            }
            else
            {
                Console.WriteLine($"It's a draw! \\_(?)_/ Computer score {computerPoints}");
                return 0;
            }

            static int GetCardValue(Card card)
            {
                string rank = card.Rank;

                switch (rank)
                {
                    case "6":
                        return 6;
                    case "7":
                        return 7;
                    case "8":
                        return 8;
                    case "9":
                        return 9;
                    case "10":
                        return 10;
                    case "Ace":
                        return 11;
                    case "King":
                        return 4;
                    case "Queen":
                        return 3;
                    case "Jack":
                        return 2;
                    default:
                        return int.Parse(rank);
                }
            }
        }
    }
}