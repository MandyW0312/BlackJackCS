# BlackJackCS

P-

Create a single (human) player game of BlackJack against the (Computer House) dealer.

Using a 52 card deck (of faces and suits)

E-

Example 1: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with the “Ace of Diamonds” and “Four of Spades”, Player “HITS” for a “Nine of Clubs”, which causes the Player to BUST. The DEALER WINS.

Example 2: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “Four of Hearts” and “Three of Clubs”, Player “HITS” for a “Queen of Clubs”, Player “STANDS”. Dealer starts with “Four of Clubs” and “Five of Spades”, Dealer “HITS” for a “Jack of Clubs”, Dealer “STANDS”. The DEALER WINS.

Example 3: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “Four of Hearts” and “Queen of Clubs”, Player “HITS” for a “Six of Diamonds”, Player “STANDS”. Dealer starts with “Nine of Spades” and “Eight of Clubs”, Dealer “STANDS”. The PLAYER WINS.

Example 4: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “Ten of Diamonds” and “Ace of Clubs”, Player “STANDS”. Dealer starts with “Six of Clubs” and “Eight of Spades”, Dealer “HITS” for a “Ten of Queens”, Dealer “BUSTS”. The PLAYER WINS.

Example 5: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “Ace of Diamonds” and “Eight of Clubs”, Player “STANDS”. Dealer starts with “King of Hearts” and “Nine of Spades” There is a TIE. The DEALER WINS.

Example 6: Dealer is dealt 2 (hidden) cards, Player is dealt 2 (seen) cards. Player starts with “King of Diamonds” and “Jack of Spades”, Player “STANDS”. Dealer starts with “Five of Clubs” and “Six of Hearts”, Dealer “HITS” for a “Seven of Spades”, Dealer “STANDS”. The PLAYER WINS.

D-

-Strings that represent the cards in the Deck
-List to represent the deck of 52 cards
-Integers to be indexes (in the shuffle)
-Class of Card - Face: Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King - Suit: Hearts, Clubs, Diamonds, Spades - Method (Value: Compute how many points the card is worth): Ace=11, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=10, Queen=10, King=10
-Class of Player/Dealer List, Called Hand? (Stores the individuals hand properties)

A-

-Create a list of strings called Deck
-Use the list of suits of cards and the list of the face of cards to “combine” that into a new list
-Determine how many points the card is worth: Ace=11, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=10, Queen=10, King=10
-Shuffle the deck (list)
-The dealer is dealt 2 cards from the top of the deck (index [0] and index [1]), these cards are hidden from the player. (Removed from the deck and goes to the dealers hand)
-The player is then dealt 2 cards from the top of the deck (index [0] and index [1]), these cards are shown (Console.WriteLine) to the player. (Removed from the deck and goes to the players hand). _method for showing the players cards_
-The player then looks at the value of their 2 cards. The player can choose to “HIT” and be dealt the next card on top of the deck (index [0] and removed from deck and placed to the players hand). The player can choose to “HIT” until they decide to stop or “STAND” or until they go over 21 which means they “BUST” and they LOSE.
-If the player “STANDS”, the dealer reveals (shows) its hand and based on the value of their cards will choose to “HIT” until they have 17 or more.
-If the dealer goes over 21, they “BUST” and the dealer loses.
-App should display the winner (Prompt? Alert?), (Calculation of adding the cards in each hand, whichever is bigger) the winner is whoever is closer to BlackJack (21) without going over.
-If the value of each players hand is tied, the dealer WINS.
(playerHand.value == dealerHand.value)
-Option to restart the game
-Remake and Reshuffle Deck
-Neither player has cards in their hand (Clear the Player/Deck Class)
