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

    // returns whether the given hand is a straight flush or not 
    public bool IsStraightFlush(List<Card> hand)
    {
        return (IsStraight(hand) && IsFlush(hand)) ? true : false;
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

    // returns whether the given hand is a Full House or not 
    public bool IsFullHouse(List<Card> hand)
    {
        return (IsPair(hand) && IsThreeOfAKind(hand));
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

}
