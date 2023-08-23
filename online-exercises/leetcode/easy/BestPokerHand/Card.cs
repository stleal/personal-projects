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
public class Card
{

    // global variables 
    private string _suit;
    private int _rank; 

    // default constructor 
    public Card()
    {
    }

    // constructor 
    public Card(string suit, int rank)
    {
        _suit = suit; 
        _rank = rank; 
    }

    // returns the suit of the card 
    public string GetSuit()
    {
        return _suit; 
    }

    // returns the rank of the card 
    public int GetRank() 
    { 
        return _rank; 
    }

}
