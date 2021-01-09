using System;
using System.Collections.Generic;

namespace BlackJackCS
{

    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
    }

    class Player
    {
        public List<Card> Hand { get; set; }
        public int HandValue()
        {
            return 0;
        }
    }

    class Deck
    {
        private List<Card> cards;
        public void Shuffle()
        {
            ResetTheDeck();
            ShuffleTheDeck();
        }
        public void ShuffleTheDeck()
        {
            var numberOfCards = cards.Count;
            var randomNumberGenerator = new Random();
            for (var rightIndex = cards.Count - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = cards[leftIndex];
                var rightCard = cards[rightIndex];
                cards[leftIndex] = rightCard;
                cards[rightIndex] = leftCard;
            }
        }

        private void ResetTheDeck()
        {
            cards = new List<Card>();
            var suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
            var faces = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var s in suits)
            {
                for (var i = 0; i < 13; i++)
                {
                    int value = 0;
                    if (i < 9)
                    {
                        value = i + 2;
                    }
                    else if (i > 7 && 1 < 12)
                    {
                        value = 10;
                    }
                    else if (i == 12)
                    {
                        value = 11;
                    }

                    var suit = s;
                    var face = faces[i];

                    var card = new Card();
                    card.Value = value;
                    card.Suit = suit;
                    card.Face = face;

                    cards.Add(card);
                }
            }
        }
        public Card Draw()
        {
            if (cards == null)
            {
                Shuffle();
            }
            var drawnCard = cards[0];
            var removeTheCard = cards.Remove(drawnCard);
            return drawnCard;
        }
    }

    class Game
    {
        public Deck Deck { get; set; }
        public Player Dealer { get; set; }
        public Player Human { get; set; }

        public void PlayGame()
        {
            Deck.Shuffle();
            Dealer.Hand = new List<Card>();
            Human.Hand = new List<Card>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shoe = new Deck();
            var card = shoe.Draw();

            Console.WriteLine($"{card.Face} of {card.Suit}");
        }


        //Create a player hand
        //Create a dealer hand
        //Ask the deck for a card (remove index [0]) and place it in the player hand
        //Ask the deck for a card (remove index [0]) and place it in the player hand
        //Ask the deck for a card (remove index [0]) and place it in the dealer hand
        //Ask the deck for a card (remove index [0]) and place it in the dealer hand
        //Show the player the cards in their hand and the TotalValue of their hand
        //If they have BUSTED, then go to step 15
        //Ask the player if they want to HIT or STAND
        //If HIT---Ask the deck for a card (remove index [0]) and place it in the player hand, repeat step 10 
        //If STAND continue on
        //If the dealer has BUSTED, then go to step 17
        //If the dealer has has than 17---Add a card (remove index[0]) and place it in the dealers hand and go back to step 14
        // Show the dealers hand TotalValue
        //If the player BUSTED show Console.WriteLine("The Dealer Wins")
        //If the dealer BUSTED show Console.WriteLine("The Player Wins") 
        //If the dealerHandValue is more than the playerHandValue then show "The Dealer Wins", else show "The Player Wins"
        //dealerHandValue > playerHandValue Console.WriteLine("The Dealer Wins")
        //playerHandValue > dealerHandValue Console.WriteLine("The Player Wins")
        //If the value of the hands are even, show "The Dealer Wins"
        //dealerHandValue == playerHandValue Console.WriteLine("The Dealer Wins")
    }
}

