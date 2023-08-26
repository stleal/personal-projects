/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/23/2023 
 * Filename: TexasHoldEm.cs 
 * Description: An interactive software application, where you get to play 1x1 against a Computer (AI) in a game of Poker (Texas Hold 'Em). 
 * 
 * Features: 
 * 
 *  - Games consist of one (1) deck of 52 cards. 
 *  - If the Deck runs out of cards, the player with the most Poker Chips, wins! 
 *  - First player to reach 0 Poker Chips loses! 
 *  - Fully functional turn-by-turn based game with Check, Call, Raise, and Fold methods. 
 *  - Includes a Dealer.cs class that can: 
 *      - Deal Cards (PreFlop) 
 *      - Draw Cards (Flop, Turn, and River), 
 *      - Evaulate the hand rankings of the cards given (5 or 7 at a time),
 *      - Determines the winner based on the hand rankings of the two hands provided. 
 *  - Play again (Y/N) option at the end of each game. 
 *
 * Additional Resources: 
 * 
 *  - https://www.wsop.com/poker-games/texas-holdem/rules/ 
 *  - https://www.poker.org/poker-terms/big-blind-poker/ 
 *  - https://www.wsop.com/poker-games/texas-holdem/rules/
 *
********************************************************************************************************************************************************************/
public class Deck
{

    // global constants 
    private readonly string[] SUITS = { "Hearts", "Clovers", "Diamonds", "Spades" };
    private readonly int MAX_SIZE = 52; 

    // global variables 
    private int _size;
    private int _capacity; 
    private List<Card> _availableCards; 

    // default constructor 
    public Deck()
    {
        _capacity = MAX_SIZE;
        _size = _capacity; 
        _availableCards = new List<Card>();
        DefaultShuffle(); 
    }

    // shuffles the cards back into the deck 
    public void ShuffleDeck()
    {

        // declare local variables 
        Random r;
        int index; 
        List<Card> shuffledDeck;

        // initialize local variables 
        r = new Random(); 
        shuffledDeck = new List<Card>();
        _size = _capacity; 

        // empty the List of available cards 
        _availableCards.Clear();

        // execute the default shuffle method 
        DefaultShuffle();

        // shuffles the deck 
        for (int i = 0; i < _size; i++)
        {
            index = r.Next(0, _availableCards.Count); 
            shuffledDeck.Add(_availableCards[index]);
            _availableCards.RemoveAt(index); 
        }

        // assigns the shuffled deck back into the available cards 
        _availableCards = shuffledDeck; 

    }

    // shuffles the remaining cards in the deck 
    public void ShuffleRemainingCards()
    {

        // declare local variables 
        Random r;
        int index;
        List<Card> shuffledDeck;

        // initialize local variables 
        r = new Random();
        shuffledDeck = new List<Card>();

        // shuffles the deck 
        for (int i = 0; i < _size; i++)
        {
            index = r.Next(0, _availableCards.Count);
            shuffledDeck.Add(_availableCards[index]);
            _availableCards.RemoveAt(index);
        }

        // assigns the shuffled deck back into the available cards 
        _availableCards = shuffledDeck;

    }

    // draws 5 cards from the top of the deck 
    public List<Card> DrawHand()
    {

        // declare local variables 
        List<Card> cards;

        // initialize local variables 
        cards = new List<Card>(); 

        // draws 5 cards from the top of the deck 
        for (int i = 0; i < 5; i++)
        {
            cards.Add(_availableCards[0]);
            _availableCards.RemoveAt(0); 
        }

        // subtract 5 from size 
        _size -= 5; 

        // returns the cards 
        return cards; 

    }

    // draws 5 cards randomly from the deck 
    public List<Card> DrawHandRandomlyFromDeck()
    {

        // declare local variables 
        Random r;
        List<Card> cards;
        int index; 

        // initialize local variables 
        r = new Random();
        cards = new List<Card>(); 

        // randomly draw 5 cards 
        for (int i = 0; i < 5; i++)
        {
            index = r.Next(0, _availableCards.Count);
            cards.Add(_availableCards[index]);
            _availableCards.RemoveAt(index); 
        }

        // subtract 5 from size 
        _size -= 5;

        // return the hand 
        return cards; 

    }

    // draws x number of cards from the top of the deck 
    public List<Card> DrawCards(int numberOfCards)
    {

        // declare local variables 
        List<Card> cards;

        // initialize local variables 
        cards = new List<Card>();

        // draws 5 cards from the top of the deck 
        for (int i = 0; i < numberOfCards; i++)
        {
            cards.Add(_availableCards[0]);
            _availableCards.RemoveAt(0);
        }

        // subtracts x from size 
        _size -= numberOfCards;

        // returns the cards 
        return cards;

    }

    // shuffles the deck back into the original order they were in when the deck was opened 
    public void DefaultShuffle()
    {
        Card c; 
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                c = new Card(SUITS[i], (j + 1)); 
                _availableCards.Add(c);
            }
        }
    }

    // prints the remaining cards in the deck 
    public void PrintDeck()
    {
        for (int i = 0; i < _size; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + _availableCards[i].GetRank() + " of " + _availableCards[i].GetSuit());
        }
    }

    // returns the remaining size of the deck 
    public int GetRemainingSize()
    {
        return _size;
    }

    // returns the available cards 
    public List<Card> GetAvailableCards()
    {
        return _availableCards; 
    }

    // sets the size 
    public void SetSize(int size)
    {
        _size = size; 
    }

}
