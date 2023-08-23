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
 *    - Calls the Default Shuffle method to place the Deck back into the original order in which it came in when the deck was opened.  
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
public class Program
{

    // global variables 
    private static Dealer _dealer; 

    // main 
    public static void Main(string[] args)
    {

        // display a welcome message 
        Console.WriteLine("Best Poker Hand"); 
        Console.WriteLine();

        // initialize global variables 
        _dealer = new Dealer();

        // unit test cases 
        UnitTestRoyalFlush();
        UnitTestStraightFlush(); 
        UnitTestFourOfAKind(); 
        UnitTestFullHouse(); 
        UnitTestFlush();
        UnitTestStraight();
        UnitTestThreeOfAKind(); 
        UnitTestTwoPair(); 
        UnitTestPair(); 
        UnitTestHighCard(); 

        // unit test case for a Random drawing of cards from the deck 
        UnitTestRandomHand();

        // keep the application running 
        Console.ReadLine(); 

    }

    // unit test case for the royal flush
    public static void UnitTestRoyalFlush()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> royalFlush;
        royalFlush = new List<Card>();
        royalFlush.Add(new Card("Clovers", 10)); // 10 
        royalFlush.Add(new Card("Clovers", 11)); // 11 = Jack 
        royalFlush.Add(new Card("Clovers", 12)); // 12 = Queen 
        royalFlush.Add(new Card("Clovers", 13)); // 13 = King 
        royalFlush.Add(new Card("Clovers", 1)); // 1 = Ace 

        // print the hand of cards 
        for (int i = 0; i < royalFlush.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + royalFlush[i].GetRank() + " of " + royalFlush[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(royalFlush);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for the straight flush
    public static void UnitTestStraightFlush()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> straightFlush;
        straightFlush = new List<Card>();
        straightFlush.Add(new Card("Hearts", 6)); 
        straightFlush.Add(new Card("Hearts", 7));
        straightFlush.Add(new Card("Hearts", 5)); 
        straightFlush.Add(new Card("Hearts", 8)); 
        straightFlush.Add(new Card("Hearts", 9)); 

        // print the hand of cards 
        for (int i = 0; i < straightFlush.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + straightFlush[i].GetRank() + " of " + straightFlush[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(straightFlush);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for four-of-a-kind 
    public static void UnitTestFourOfAKind()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> fourOfAKind;
        fourOfAKind = new List<Card>();
        fourOfAKind.Add(new Card("Hearts", 1));
        fourOfAKind.Add(new Card("Spades", 1));
        fourOfAKind.Add(new Card("Clovers", 1));
        fourOfAKind.Add(new Card("Diamonds", 1));
        fourOfAKind.Add(new Card("Hearts", 12));

        // print the hand of cards 
        for (int i = 0; i < fourOfAKind.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + fourOfAKind[i].GetRank() + " of " + fourOfAKind[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(fourOfAKind);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for Full House  
    public static void UnitTestFullHouse()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> fullHouse;
        fullHouse = new List<Card>();
        fullHouse.Add(new Card("Hearts", 1));
        fullHouse.Add(new Card("Spades", 1));
        fullHouse.Add(new Card("Clovers", 1));
        fullHouse.Add(new Card("Diamonds", 13));
        fullHouse.Add(new Card("Hearts", 13));

        // print the hand of cards 
        for (int i = 0; i < fullHouse.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + fullHouse[i].GetRank() + " of " + fullHouse[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(fullHouse);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for the flush 
    public static void UnitTestFlush()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> flush;
        flush = new List<Card>();
        flush.Add(new Card("Hearts", 4));
        flush.Add(new Card("Hearts", 8));
        flush.Add(new Card("Hearts", 6));
        flush.Add(new Card("Hearts", 7));
        flush.Add(new Card("Hearts", 2));

        // print the hand of cards 
        for (int i = 0; i < flush.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + flush[i].GetRank() + " of " + flush[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(flush);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for the straight 
    public static void UnitTestStraight()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> straight;
        straight = new List<Card>();
        straight.Add(new Card("Diamonds", 6));
        straight.Add(new Card("Clovers", 7));
        straight.Add(new Card("Diamonds", 5));
        straight.Add(new Card("Diamonds", 4));
        straight.Add(new Card("Diamonds", 3));

        // print the hand of cards 
        for (int i = 0; i < straight.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + straight[i].GetRank() + " of " + straight[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(straight);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for three-of-a-kind 
    public static void UnitTestThreeOfAKind()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> threeOfAKind;
        threeOfAKind = new List<Card>();
        threeOfAKind.Add(new Card("Hearts", 1));
        threeOfAKind.Add(new Card("Spades", 1));
        threeOfAKind.Add(new Card("Clovers", 1));
        threeOfAKind.Add(new Card("Diamonds", 12));
        threeOfAKind.Add(new Card("Hearts", 13));

        // print the hand of cards 
        for (int i = 0; i < threeOfAKind.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + threeOfAKind[i].GetRank() + " of " + threeOfAKind[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(threeOfAKind);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for two-pair 
    public static void UnitTestTwoPair()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> twoPair;
        twoPair = new List<Card>();
        twoPair.Add(new Card("Hearts", 13));
        twoPair.Add(new Card("Spades", 13));
        twoPair.Add(new Card("Clovers", 12));
        twoPair.Add(new Card("Diamonds", 12));
        twoPair.Add(new Card("Hearts", 1));

        // print the hand of cards 
        for (int i = 0; i < twoPair.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + twoPair[i].GetRank() + " of " + twoPair[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(twoPair);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for pair 
    public static void UnitTestPair()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> pair;
        pair = new List<Card>();
        pair.Add(new Card("Hearts", 1));
        pair.Add(new Card("Spades", 1));
        pair.Add(new Card("Clovers", 10));
        pair.Add(new Card("Diamonds", 11));
        pair.Add(new Card("Hearts", 12));

        // print the hand of cards 
        for (int i = 0; i < pair.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + pair[i].GetRank() + " of " + pair[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(pair);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // unit test case for pair 
    public static void UnitTestHighCard()
    {

        // declare local variables 
        string handRanking;

        // unit testing 
        List<Card> highCard;
        highCard = new List<Card>();
        highCard.Add(new Card("Hearts", 2));
        highCard.Add(new Card("Spades", 3));
        highCard.Add(new Card("Clovers", 4));
        highCard.Add(new Card("Diamonds", 6));
        highCard.Add(new Card("Hearts", 7));

        // print the hand of cards 
        for (int i = 0; i < highCard.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + highCard[i].GetRank() + " of " + highCard[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(highCard);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

    // randomly selects 5 cards from the deck
    public static void UnitTestRandomHand()
    {

        // declare local variables 
        Deck d;
        string handRanking;

        // initialize local variables 
        d = new Deck();

        // print the Deck 
        Console.WriteLine("Before Shuffle: "); 
        d.PrintDeck();
        Console.WriteLine();

        // shuffle the Deck 
        d.ShuffleDeck();

        // print the Deck 
        Console.WriteLine("After Shuffle: "); 
        d.PrintDeck(); 
        Console.WriteLine();

        // draw a hand of cards 
        List<Card> hand = d.DrawHand(); 

        // print the hand of cards 
        for (int i = 0; i < hand.Count; i++)
        {
            Console.WriteLine("Card at index of " + i + ": " + hand[i].GetRank() + " of " + hand[i].GetSuit());
        }

        // determine the hand ranking 
        handRanking = _dealer.DetermineHandRanking(hand);

        // print the hand ranking 
        Console.WriteLine("Congratulations!! You're hand is a: " + handRanking);
        Console.WriteLine();

    }

}
