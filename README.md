# BlackJackCS

P-

- Create a single (human) player game of BlackJack against the (Computer House) dealer.

- Using a 52 card deck (of faces and suits)

E-

- Example 1: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with the “Ace of Diamonds” and “4 of Spades”, Player “HITS” for a “9 of Clubs”, which causes the Player to BUST. The DEALER WINS.

- Example 2: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “4 of Hearts” and “3 of Clubs”, Player “HITS” for a “Queen of Clubs”, Player “STANDS”. Dealer starts with “4 of Clubs” and “5 of Spades”, Dealer “HITS” for a “Jack of Clubs”, Dealer “STANDS”. The DEALER WINS.

- Example 3: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “4 of Hearts” and “Queen of Clubs”, Player “HITS” for a “6 of Diamonds”, Player “STANDS”. Dealer starts with “9 of Spades” and “8 of Clubs”, Dealer “STANDS”. The PLAYER WINS.

- Example 4: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “10 of Diamonds” and “Ace of Clubs”, Player “STANDS”. Dealer starts with “6 of Clubs” and “8 of Spades”, Dealer “HITS” for a “10 of Queens”, Dealer “BUSTS”. The PLAYER WINS.

- Example 5: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “Ace of Diamonds” and “8 of Clubs”, Player “STANDS”. Dealer starts with “King of Hearts” and “9 of Spades” There is a TIE. The DEALER WINS.

- Example 6: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “King of Diamonds” and “Jack of Spades”, Player “STANDS”. Dealer starts with “5 of Clubs” and “6 of Hearts”, Dealer “HITS” for a “7 of Spades”, Dealer “STANDS”. The PLAYER WINS.

D-

- Strings that represent the cards in the Deck
- List to represent the deck of 52 cards
- Integers to be indexes (in the shuffle)
- Class of Card
  -- Face: Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King
  -- Suit: Hearts, Clubs, Diamonds, Spades
  -- Method ValueOfCards (Value: Compute how many points the card is worth): Ace=11, 2=2, 3=3, 4=4, 5=5, 6=6, 7=7, 8=8, 9=9, 10=10, Jack=10, Queen=10, King=10
- Class of Player/Dealer List, Called Hand? (Stores the individuals hand properties)
  -- Method: ShowPlayersHand Console.WriteLine()
- Method for HIT: Hit
- Method for BUST: Bust

A-

- Create a list of strings for the 52 cards called Deck
  -- Use the list of suits of cards and the list of the face of cards to “combine” that into a new list
- Determine how many points the card is worth: Ace=11, 2=2, 3=3, 4=4, 5=5, 6=6, 7=7, 8=8, 9=9, 10=10, Jack=10, Queen=10, King=10
- Shuffle the deck (list)
- The dealer is dealt 2 cards from the top of the deck (index [0] and index [1]), these cards are hidden from the player.
  -- Remove the card from the deck and goes to the dealers hand. (deck.Remove(firstCard)) (deck.Remove(secondCard))
- The player is then dealt 2 cards from the top of the deck (index [0] and index [1]),
  -- These cards are shown (Console.WriteLine) to the player.
  -- Remove the card from the deck and goes to the players hand. (deck.Remove(firstCard)) (deck.Remove(secondCard))

- Method for showing the players cards ShowPlayersHand

- The player then looks at the value of their 2 cards. The player can choose to “HIT” and be dealt the next card on top of the deck (index [0] and removed from deck and placed to the players hand). The player can choose to “HIT” until they decide to stop/“STAND” or until they go over 21 which means they “BUST” and they LOSE.

- Method for "HIT"

- If the player “STANDS”, the dealer reveals its hand and based on the value of their cards will choose to “HIT” until they have 17 or more.

- Method for showing the players cards ShowPlayersHand

- Method for "BUST" (Console.WriteLine())

- If the dealer goes over 21, they “BUST” and the dealer loses.
- App should display the winner (Console.WriteLine()), (Calculation of adding the cards in each hand, whichever is bigger. Calculation for comparing the players hands.) the winner is whoever is closer to BlackJack (21) without going over.
- If the value of each players hand is tied, the dealer WINS. (playerHand.value == dealerHand.value) (Console.WriteLine(The Dealer WINS!))
- Option to restart the game (while loop)
  -- Remake and Reshuffle Deck
  -- Neither player has cards in their hand (Clear the Player/Deck Class)
