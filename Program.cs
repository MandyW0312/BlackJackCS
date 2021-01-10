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
        public string Name { get; set; }
        public List<Card> Hand = new List<Card>();
        public int HandValue()
        {
            var total = 0;
            foreach (var c in Hand)
            {
                total = total + c.Value;
            }
            return total;
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
            Console.Write("Hello, What is your name? ");
            var playerName = Console.ReadLine();

            var firstPlayer = new Player();
            firstPlayer.Name = playerName;

            Console.WriteLine($"Hello, {firstPlayer.Name}. ");

            var shoe = new Deck();
            shoe.Shuffle();

            var dealerPlayer = new Player();

            var cardOne = shoe.Draw();
            dealerPlayer.Hand.Add(cardOne);
            var cardTwo = shoe.Draw();
            dealerPlayer.Hand.Add(cardTwo);
            var cardThree = shoe.Draw();
            firstPlayer.Hand.Add(cardThree);
            var cardFour = shoe.Draw();
            firstPlayer.Hand.Add(cardFour);


            var initialTotal = firstPlayer.HandValue();
            Console.WriteLine($"{firstPlayer.Name} got a {cardOne.Face} of {cardOne.Suit} and a {cardTwo.Face} of {cardTwo.Suit}");
            Console.WriteLine($"Which has a total of {initialTotal}");

            if (initialTotal == 21)
            {
                Console.WriteLine("Congrats on getting BlackJack");
                return;
            }
            else if (initialTotal > 21)
            {
                Console.WriteLine("Sorry, the Dealer Wins");
            }

            Console.Write("Would you like to Hit (type h) or Stand (type s)? ");
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "h")
            {
                var hitCard = shoe.Draw();
                firstPlayer.Hand.Add(hitCard);
                Console.WriteLine($"{firstPlayer.Name} Hit");
                Console.WriteLine($"{firstPlayer.Name} got a {hitCard.Face} of {hitCard.Suit}");
            }
            else if (userInput.ToLower() == "s")
            {
                Console.WriteLine($"{firstPlayer.Name} Stands");
            }


            Console.WriteLine($"{firstPlayer.Name} got a {firstPlayer.HandValue()}");

            var dealerInitialTotal = dealerPlayer.HandValue();
            if (dealerInitialTotal > 21)
            {
                Console.WriteLine("The Dealer has Busted, the Player Wins!");
            }
            else if (dealerInitialTotal < 17)
            {
                var drawCard = shoe.Draw();
                dealerPlayer.Hand.Add(drawCard);
                Console.WriteLine($"The Dealer's Hand Value is {dealerPlayer.HandValue()}");
            }

            if (firstPlayer.HandValue() > 21)
            {
                Console.WriteLine("Bust, The Dealer Wins");
            }
            else if (dealerPlayer.HandValue() > 21)
            {
                Console.WriteLine("Bust, The Player Wins");
            }
            else if (dealerPlayer.HandValue() > firstPlayer.HandValue())
            {
                Console.WriteLine("The Dealer Wins");
            }
            else if (dealerPlayer.HandValue() < firstPlayer.HandValue())
            {
                Console.WriteLine("The Player Wins");
            }
            else if (dealerPlayer.HandValue() == firstPlayer.HandValue())
            {
                Console.WriteLine("Sorry, The Dealer Wins");
            }

            Console.Write("Would you like to play again? (y for yes and n for no) ");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Deck.Shuffle();
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Thanks for Playing!");
            }

        }

    }
}

