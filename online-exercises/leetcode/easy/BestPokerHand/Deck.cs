/********************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 08/21/2023 
 * Filename: BestPokerHand.cs 
 * Description: You are given a hand of 5 cards as a List<Card>. 
 * 
 * Please write a program that returns the highest possible poker hand that can be made. 
 * 
 *      DetermineHandRanking(List<Card> hand) 
 * 
 * Write methods to test the following scenarios / conditions: 
 * 
 *      Royal Flush 
 *      Straight Flush 
 *      Four Of A Kind  
 *      Full House  
 *      Flush 
 *      Straight 
 *      Three Of A Kind 
 *      Two Pair 
 *      Pair 
 *      High Card 
 * 
 * Be sure to test creating a new Deck of 52 cards, shuffling the deck, and drawing the top 5 cards from the deck. Then, run it through the 
 * DetermineHandRanking() function to see the results. 
 * 
 *      UnitTestRandomHand(List<Card> hand); 
 * 
 * This program implements a Deck.cs, and Card.cs class. 
 * 
 * Deck.cs: 
 * 
 *  Simulates a standard deck of 52 cards. 
 *  Suits composed of "Hearts", "Clovers", "Diamonds", and "Spades" 
 * 
 *  Default Constructor: 
 *  
 *    - Calls the Default Shuffle method to place the Deck in the original order they came in when a new deck is opened.  
 * 
 *  Includes methods: 
 *  
 *    - Shuffle Deck: Puts all 52 cards back into the deck, and then shuffles the deck. 
 *    - Default Shuffle: Puts the cards back in the original order they were when the deck of cards were opened. 
 *    - Draw Hand: Returns 5 hards from the top of the deck. 
 *    - Print Deck: Prints the reamining cards in the deck. 
 *    - Shuffle Remaining Deck: Shuffles the remaining cards in the deck, without placing any cards back into the deck. 
 *    - Draw Hand From Deck Randomly: Picks 5 cards randomly from the Deck. 
 * 
 * Card.cs: 
 *   
 *  Includes methods: 
 *  
 *    - GetSuit(); 
 *    - GetRank(); 
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

}
