using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the game
            Console.WriteLine("Welcome to Blackjack!");
            PlayGame();
        }

        static void PlayGame()
        {
            // Create a new deck of cards
            Deck deck = new Deck();
            deck.Shuffle();

            // Create player and dealer hands
            Hand playerHand = new Hand();
            Hand dealerHand = new Hand();

            // Deal initial cards
            playerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());

            // Show initial hands
            Console.WriteLine($"Your hand: {playerHand} (Total: {playerHand.GetTotal()})");
            Console.WriteLine($"Dealer's hand: {dealerHand.GetCard(0)} and [Hidden]");

            // Player's turn
            bool playerBusted = PlayerTurn(deck, playerHand);
            if (playerBusted)
            {
                Console.WriteLine("You busted! Dealer wins.");
                return;
            }

            // Dealer's turn
            DealerTurn(deck, dealerHand);
            Console.WriteLine($"Dealer's hand: {dealerHand} (Total: {dealerHand.GetTotal()})");

            // Determine the winner
            DetermineWinner(playerHand, dealerHand);
        }

        static bool PlayerTurn(Deck deck, Hand playerHand)
        {
            // Player's turn to hit or stand
            while (true)
            {
                Console.WriteLine("Would you like to (H)it or (S)tand?");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "H")
                {
                    playerHand.AddCard(deck.DealCard());
                    Console.WriteLine($"Your hand: {playerHand} (Total: {playerHand.GetTotal()})");
                    if (playerHand.GetTotal() > 21)
                    {
                        return true; // Player busted
                    }
                }
                else if (choice == "S")
                {
                    break; // Player stands
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'H' or 'S'.");
                }
            }
            return false; // Player did not bust
        }

        static void DealerTurn(Deck deck, Hand dealerHand)
        {
            // Dealer must hit until reaching 17 or higher
            while (dealerHand.GetTotal() < 17)
            {
                dealerHand.AddCard(deck.DealCard());
            }
        }

        static void DetermineWinner(Hand playerHand, Hand dealerHand)
        {
            int playerTotal = playerHand.GetTotal();
            int dealerTotal = dealerHand.GetTotal();

            if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer busted! You win!");
            }
            else if (playerTotal > dealerTotal)
            {
                Console.WriteLine("You win!");
            }
            else if (playerTotal < dealerTotal)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }

    // Class representing a single card
    class Card
    {
        public string Suit { get; }
        public string Rank { get; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public int GetValue()
        {
            if (Rank == "Ace") return 11; // Ace can be 1 or 11, handle in hand class
            if (Rank == "King" || Rank == "Queen" || Rank == "Jack") return 10;
            return int.Parse(Rank);
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    // Class representing a deck of cards
    class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            random = new Random();
            cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("No cards left in the deck.");

            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }
    }

    // Class representing a hand of cards
    class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int GetTotal()
        {
            int total = 0;
            int acesCount = 0;

            foreach (var card in cards)
            {
                total += card.GetValue();
                if (card.Rank == "Ace") acesCount++;
            }

            // Adjust for Aces
            while (total > 21 && acesCount > 0)
            {
                total -= 10; // Count Ace as 1 instead of 11
                acesCount--;
            }

            return total;
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
            Console.ReadLine();
        }
    }
}