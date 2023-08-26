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
