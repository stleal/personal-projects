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
public class Dealer
{

    public Dealer()
    {
    }

    // determines the hand ranking 
    public string DetermineHandRanking(List<Card> hand)
    {

        // declare local variables 
        string ranking;

        // initialize local variables 
        ranking = string.Empty;

        // determine the ranking of the given hand 
        if (IsRoyalFlush(hand))
        {
            ranking = "Royal Flush";
        }
        else if (IsStraightFlush(hand))
        {
            ranking = "Straight Flush";
        }
        else if (IsFourOfAKind(hand))
        {
            ranking = "Four of a Kind";
        }
        else if (IsFullHouse(hand))
        {
            ranking = "Full House";
        }
        else if (IsFlush(hand))
        {
            ranking = "Flush";
        }
        else if (IsStraight(hand))
        {
            ranking = "Straight";
        }
        else if (IsThreeOfAKind(hand))
        {
            ranking = "Three of a Kind";
        }
        else if (IsTwoPair(hand))
        {
            ranking = "Two Pair";
        }
        else if (IsPair(hand))
        {
            ranking = "Pair";
        }
        else
        {
            ranking = "High Card";
        }

        // return hand ranking 
        return ranking;

    }

    // determines the hand ranking 
    public string DetermineHandRanking(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        string ranking;

        // initialize local variables 
        ranking = string.Empty;

        // determine the ranking of the given hand 
        if (IsRoyalFlush(hand, communityCards))
        {
            ranking = "Royal Flush";
        }
        else if (IsStraightFlush(hand, communityCards))
        {
            ranking = "Straight Flush";
        }
        else if (IsFourOfAKind(hand, communityCards))
        {
            ranking = "Four of a Kind";
        }
        else if (IsFullHouse(hand, communityCards))
        {
            ranking = "Full House";
        }
        else if (IsFlush(hand, communityCards))
        {
            ranking = "Flush";
        }
        else if (IsStraight(hand, communityCards))
        {
            ranking = "Straight";
        }
        else if (IsThreeOfAKind(hand, communityCards))
        {
            ranking = "Three of a Kind";
        }
        else if (IsTwoPair(hand, communityCards))
        {
            ranking = "Two Pair";
        }
        else if (IsPair(hand, communityCards))
        {
            ranking = "Pair";
        }
        else
        {
            ranking = "High Card";
        }

        // return hand ranking 
        return ranking;

    }

    // evaluates the winner 
    public string EvaluateWinner(List<Card> playerHand, List<Card> computerHand, List<Card> communityCards)
    {

        // declare local variables 
        string winner; 
        string computersHandRanking;
        string playersHandRanking;
        int computersRanking, playersRanking;

        // initialize local variables 
        winner = string.Empty; 
        computersHandRanking = DetermineHandRanking(computerHand, communityCards); 
        playersHandRanking = DetermineHandRanking(playerHand, communityCards);
        computersRanking = EvaluateHandRanking(computersHandRanking);
        playersRanking = EvaluateHandRanking(playersHandRanking); 

        // determines the winner 
        if (computersRanking > playersRanking)
        {
            winner = "Computer"; 
        }
        else if (computersRanking < playersRanking)
        {
            winner = "Player"; 
        }
        else if (computersRanking == playersRanking)
        {
            winner = "Neither"; 
        }

        // returns the winner 
        return winner; 

    }

    // evaluates the hand ranking 
    public int EvaluateHandRanking(string handRanking)
    {

        // declare local variables 
        int ranking;

        // initializes local variables 
        ranking = 0; 

        // determines the ranking 
        switch (handRanking)
        {

            case "Royal Flush":
                ranking = 10;
                break;

            case "Straight Flush":
                ranking = 9;
                break;

            case "Four of a Kind":
                ranking = 8;
                break;

            case "Full House":
                ranking = 7;
                break;

            case "Flush":
                ranking = 6;
                break;

            case "Straight":
                ranking = 5;
                break;

            case "Three of a Kind":
                ranking = 4;
                break;

            case "Two Pair":
                ranking = 3;
                break;

            case "Pair":
                ranking = 2;
                break; 

            case "High Card":
                ranking = 1;
                break;

            default:
                break; 

        }

        // returns the ranking 
        return ranking;

    }

    // returns whether the given hand is a royal flush or not 
    public bool IsRoyalFlush(List<Card> hand)
    {

        // declare local variables 
        bool isRoyalFlush;

        // initialize local variables 
        isRoyalFlush = true;

        // determines whether the given hand is a flush 
        if (!IsFlush(hand))
        {
            isRoyalFlush = false;
        }
        else
        {
            // determines whether the given hand is a royal flush 
            int sum = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                sum += hand[i].GetRank();
            }
            if (sum != 47)
            {
                isRoyalFlush = false;
            }
        }

        // return whether or not the hand is a Royal Flush 
        return isRoyalFlush;

    }

    // returns whether the given hand is a royal flush or not 
    public bool IsRoyalFlush(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        List<Card> allCards; 
        bool isRoyalFlush;
        bool hasTen, hasJack, hasQueen, hasKing, hasAce; 

        // initialize local variables 
        isRoyalFlush = true;
        allCards = new List<Card>();
        allCards.AddRange(hand); 
        allCards.AddRange(communityCards);
        hasTen = hasJack = hasQueen = hasKing = hasAce = false; 

        // determines whether the given hand is a flush 
        if (!IsFlush(hand, communityCards))
        {
            isRoyalFlush = false;
        }
        else
        {

            // checks if the hand + community cards is a royal flush 
            for (int i = 0; i < allCards.Count; i++)
            {

                switch (allCards[i].GetRank())
                {

                    case 10:
                        hasTen = true; 
                        break;

                    case 11:
                        hasJack = true; 
                        break;

                    case 12:
                        hasQueen = true; 
                        break;

                    case 13:
                        hasKing = true; 
                        break;

                    case 1:
                        hasAce = true;
                        break; 

                    default:
                        break;

                }

            } 

            // determines whether the hand + community cards is a royal flush 
            if (!hasTen || !hasJack || !hasQueen | !hasKing || !hasAce)
            {
                isRoyalFlush = false; 
            }

        }

        // return whether or not the hand is a Royal Flush 
        return isRoyalFlush;

    }

    // returns whether the given hand is a straight flush or not 
    public bool IsStraightFlush(List<Card> hand)
    {
        return (IsStraight(hand) && IsFlush(hand)) ? true : false;
    }

    // returns whether the given hand is a straight flush or not 
    public bool IsStraightFlush(List<Card> hand, List<Card> communityCards)
    {
        return (IsStraight(hand, communityCards) && IsFlush(hand, communityCards)) ? true : false;
    }

    // returns whether the given hand is four-of-a-kind or not 
    public bool IsFourOfAKind(List<Card> hand)
    {

        // declare local variables 
        bool isFourOfAKind;
        int[] ranks;

        // initialize local variables 
        isFourOfAKind = false;
        ranks = new int[13];

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < hand.Count; i++)
        {
            ranks[hand[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if any of the values is equal to 4 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 4)
            {
                isFourOfAKind = true;
            }
        }

        // return whether the hand is four-of-a-kind or not 
        return isFourOfAKind;

    }

    // returns whether the given hand is four-of-a-kind or not 
    public bool IsFourOfAKind(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        bool isFourOfAKind;
        int[] ranks;
        List<Card> allCards; 

        // initialize local variables 
        isFourOfAKind = false;
        ranks = new int[13];
        allCards = new List<Card>();
        allCards.AddRange(hand);
        allCards.AddRange(communityCards); 

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < allCards.Count; i++)
        {
            ranks[allCards[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if any of the values is equal to 4 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 4)
            {
                isFourOfAKind = true;
            }
        }

        // return whether the hand is four-of-a-kind or not 
        return isFourOfAKind;

    }

    // returns whether the given hand is a Full House or not 
    public bool IsFullHouse(List<Card> hand)
    {
        return (IsPair(hand) && IsThreeOfAKind(hand));
    }

    // returns whether the given hand is a Full House or not 
    public bool IsFullHouse(List<Card> hand, List<Card> communityCards)
    {
        return (IsPair(hand, communityCards) && IsThreeOfAKind(hand, communityCards));
    }

    // returns whether the hand is a flush or not 
    public bool IsFlush(List<Card> hand)
    {
        bool isFlush;
        isFlush = true;
        for (int i = 0; i < hand.Count; i++)
        {
            for (int j = 0; j < hand.Count; j++)
            {
                if ((hand[i].GetSuit() != hand[j].GetSuit()) && (i != j))
                {
                    isFlush = false;
                    break;
                }
            }
            if (!isFlush)
            {
                break;
            }
        }
        return isFlush;
    }

    // returns whether the hand is a flush or not 
    public bool IsFlush(List<Card> hand, List<Card> communityCards)
    {
        
        // declare local variables 
        bool isFlush;
        List<Card> allCards;
        int[] suitCounter; 
        
        // initialize local variables 
        isFlush = false;
        suitCounter = new int[4]; // hearts, clovers, diamonds, spades 
        allCards = new List<Card>(); 
        allCards.AddRange(hand);
        allCards.AddRange(communityCards); 

        // counts the number of suits in the hand + community cards 
        for (int i = 0; i < allCards.Count; i++)
        {

            switch (allCards[i].GetSuit())
            {

                case "Hearts":
                    suitCounter[0]++;
                    break;

                case "Clovers":
                    suitCounter[1]++;
                    break;

                case "Diamonds":
                    suitCounter[2]++; 
                    break;

                case "Spades":
                    suitCounter[3]++;
                    break;

                default: 
                    break;

            }

        }

        // checks if any of the suits has a total count of 5 
        for (int i = 0; i < suitCounter.Length; i++)
        {
            if (suitCounter[i] == 5)
            {
                isFlush = true;
                break; 
            }
        }

        // returns whether the given hand is a flush or not 
        return isFlush;

    }

    // returns whether the hand is a straight or not 
    public bool IsStraight(List<Card> hand)
    {

        // declare local variables 
        int difference;
        bool isStraight;
        List<Card> sortedHand;

        // initialize local variables 
        isStraight = true;
        sortedHand = SortHand(hand);

        // determines if the sorted hand is a straight 
        for (int i = 0; i < sortedHand.Count - 1; i++)
        {
            difference = sortedHand[i + 1].GetRank() - sortedHand[i].GetRank();
            if (difference != 1)
            {
                isStraight = false;
                break;
            }
        }

        // returns whether the hand is a straight or not 
        return isStraight;

    }

    // returns whether the hand is a straight or not 
    public bool IsStraight(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        int difference;
        bool isStraight;
        List<Card> sortedHand;
        List<Card> allCards; 

        // initialize local variables 
        isStraight = true;
        allCards = new List<Card>();
        allCards.AddRange(hand); 
        allCards.AddRange(communityCards); 
        allCards = SortHand(allCards); 
        
        // for example: 
        // 6, 7, 8, 9, 10, Jack, Ace => straight 
        // or could be: 6, 7, 7, 8, 9, 10, Jack => straight (after removing the duplicate 7) 
        // could be 4, 4, 4, 5, 6, 7, 8 => straight 
        // after removing duplicates: 4, 5, 6, 7, 8 => straight 

        // remove duplicates from the list of cards 
        for (int i = 0; i < allCards.Count; i++)
        {
            for (int j = 0; j < allCards.Count; j++)
            {
                if (i != j && allCards[i].GetRank() == allCards[j].GetRank())
                {
                    allCards.RemoveAt(j); 
                }
            }
        }

        // determines if the sorted hand is a straight 
        for (int i = 0; i < allCards.Count - 1; i++)
        {
            difference = allCards[i + 1].GetRank() - allCards[i].GetRank();
            if (difference != 1)
            {
                isStraight = false;
                break;
            }
        }

        // returns whether the hand is a straight or not 
        return isStraight;

    }

    // returns whether the given hand is three-of-a-kind or not 
    public bool IsThreeOfAKind(List<Card> hand)
    {

        // declare local variables 
        bool isThreeOfAKind;
        int[] ranks;

        // initialize local variables 
        isThreeOfAKind = false;
        ranks = new int[13];

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < hand.Count; i++)
        {
            ranks[hand[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if any of the values is equal to 3 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 3)
            {
                isThreeOfAKind = true;
            }
        }

        // return whether the hand is three-of-a-kind or not 
        return isThreeOfAKind;

    }

    // returns whether the given hand is three-of-a-kind or not 
    public bool IsThreeOfAKind(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        int[] ranks;
        bool isThreeOfAKind;
        List<Card> allCards;

        // initialize local variables 
        ranks = new int[13];
        isThreeOfAKind = false;
        allCards = new List<Card>();
        allCards.AddRange(hand);
        allCards.AddRange(communityCards);

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < allCards.Count; i++)
        {
            ranks[allCards[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if any of the values is equal to 3 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 3)
            {
                isThreeOfAKind = true;
            }
        }

        // return whether the hand is three-of-a-kind or not 
        return isThreeOfAKind;

    }

    // returns whether the given hand has a two-pair 
    public bool IsTwoPair(List<Card> hand)
    {

        // declare local variables 
        int pairs;
        int[] ranks;
        bool isTwoPair;

        // initialize local variables 
        pairs = 0;
        isTwoPair = false;
        ranks = new int[13];

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < hand.Count; i++)
        {
            ranks[hand[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if there are two pairs 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 2)
            {
                pairs += 1;
            }
        }

        // checks if there are two pairs 
        if (pairs == 2)
        {
            isTwoPair = true;
        }

        // returns whether the hand has a two pair or not 
        return isTwoPair;

    }

    // returns whether the given hand has a two-pair 
    public bool IsTwoPair(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        int pairs;
        int[] ranks;
        bool isTwoPair;
        List<Card> allCards; 

        // initialize local variables 
        pairs = 0;
        isTwoPair = false;
        ranks = new int[13];
        allCards = new List<Card>();
        allCards.AddRange(hand);
        allCards.AddRange(communityCards);

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < allCards.Count; i++)
        {
            ranks[allCards[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if there are two pairs 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 2)
            {
                pairs += 1;
            }
        }

        // checks if there are two pairs 
        if (pairs >= 2)
        {
            isTwoPair = true;
        }

        // returns whether the hand has a two pair or not 
        return isTwoPair;

    }

    // returns whether the given hand has a pair 
    public bool IsPair(List<Card> hand)
    {

        // declare local variables 
        int pairs;
        int[] ranks;
        bool isPair;

        // initialize local variables 
        pairs = 0;
        isPair = false;
        ranks = new int[13];

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < hand.Count; i++)
        {
            ranks[hand[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if there are two pairs 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 2)
            {
                pairs += 1;
            }
        }

        // checks if there is a pair of cards in the hand 
        if (pairs == 1)
        {
            isPair = true;
        }

        // returns whether the hand has a two pair or not 
        return isPair;

    }

    // returns whether the given hand has a pair 
    public bool IsPair(List<Card> hand, List<Card> communityCards)
    {

        // declare local variables 
        int pairs;
        int[] ranks;
        bool isPair;
        List<Card> allCards;

        // initialize local variables 
        pairs = 0;
        isPair = false;
        ranks = new int[13];
        allCards = new List<Card>();
        allCards.AddRange(hand);
        allCards.AddRange(communityCards);

        // save the count of occurences of each card rank into ranks 
        for (int i = 0; i < allCards.Count; i++)
        {
            ranks[allCards[i].GetRank() - 1] += 1;
        }

        // loop through the ranks array to double-check and see if there are two pairs 
        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == 2)
            {
                pairs += 1;
            }
        }

        // checks if there is a pair of cards in the hand 
        if (pairs == 1)
        {
            isPair = true;
        }

        // returns whether the hand has a two pair or not 
        return isPair;

    }

    // sort the hand of cards 
    public List<Card> SortHand(List<Card> unsortedHand)
    {

        // declare local variables 
        Card swap;
        List<Card> sortedHand;

        // initialize local variables 
        sortedHand = new List<Card>();

        // copies the unsorted hand into a duplicate hand 
        for (int i = 0; i < unsortedHand.Count; i++)
        {
            sortedHand.Add(unsortedHand[i]);
        }

        // sorts the unsorted hand 
        for (int i = 0; i < sortedHand.Count; i++)
        {
            for (int j = 0; j < sortedHand.Count - 1; j++)
            {
                if (sortedHand[i].GetRank() < sortedHand[j].GetRank())
                {
                    swap = sortedHand[i];
                    sortedHand[i] = sortedHand[j];
                    sortedHand[j] = swap;
                }
            }
        }

        // returns the sorted hand 
        return sortedHand;

    }

    // draws x number of cards from the top of the deck 
    public List<Card> DrawCards(Deck d, int numberOfCards)
    {

        // declare local variables 
        List<Card> cards;

        // initialize local variables 
        cards = new List<Card>();

        // draws 5 cards from the top of the deck 
        for (int i = 0; i < numberOfCards; i++)
        {
            cards.Add(d.GetAvailableCards()[0]);
            d.GetAvailableCards().RemoveAt(0);
        }

        // subtracts x from size 
        d.SetSize(d.GetRemainingSize() - numberOfCards); 

        // returns the cards 
        return cards;

    }

    // Deal Preflop 
    public void DealPreFlop(List<List<Card>> playerCards, Deck d)
    {

        // declare local variables 
        int counter;
        List<Card> preFlop;

        // initialize local variables 
        counter = 0;
        preFlop = new List<Card>();

        // draw x number of cards, where x = playerCards.Count * 2
        preFlop = d.DrawCards((playerCards.Count * 2)); 

        // each player receives two (2) cards 
        for (int i = 0; i < (preFlop.Count / playerCards.Count); i++)
        {
            for (int j = 0; j < playerCards.Count; j++)
            {
                playerCards[j].Add(preFlop[counter]);
                counter++; 
            }
        }

        // this method does not return anything! 
        // the cards have been dealt into the player's hands 
        // ends here 

    }

    // Deal Flop 
    public List<Card> DealFlop(Deck d)
    {

        // declare local variables 
        List<Card> flop;

        // initialize local variables 
        flop = new List<Card>();

        // draws 5 cards from the top of the deck 
        for (int i = 0; i < 3; i++)
        {
            flop.Add(d.GetAvailableCards()[0]);
            d.GetAvailableCards().RemoveAt(0);
        }

        // subtracts x from size 
        d.SetSize(d.GetRemainingSize() - 3);

        // returns the cards 
        return flop;

    }

    // prints the given hand of cards 
    public void PrintHand(List<Card> hand)
    {

        // declare local variables 
        int rank;
        string rankMsg; 

        for (int i = 0; i < hand.Count; i++)
        {
            rank = hand[i].GetRank(); 
            switch (rank)
            {
                case 1:
                    rankMsg = "Ace"; 
                    break;
                case 11:
                    rankMsg = "Jack"; 
                    break;
                case 12:
                    rankMsg = "Queen"; 
                    break;
                case 13:
                    rankMsg = "King";
                    break;
                default:
                    rankMsg = rank.ToString(); 
                    break; 
            }
            Console.WriteLine("Card at index of " + i + ": " + rankMsg + " of " + hand[i].GetSuit());
        }
    }

}
