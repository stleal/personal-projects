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
public class Program
{

    // global variables 
    private static int _bet;
    private static int _bigBlind; 
    private static string _cmd;
    private static int _computerBalance;
    private static Dealer _dealer;
    private static int _numberOfPlayers;
    private static int _playerBalance;
    private static List<int> _playersCheckedState;
    private static string _playerTurn;
    private static int _pot;
    private static Random _r;
    private static int _raise;
    private static int _turn;
    private static string _winner; 

    // main 
    public static void Main(string[] args)
    {

        // display a welcome message 
        Console.WriteLine("Texas Hold 'Em");
        Console.WriteLine();

        // initialize global variables 
        _bet = 0;
        _cmd = string.Empty;
        _dealer = new Dealer();
        _numberOfPlayers = 2;
        _playersCheckedState = new List<int>();
        _pot = 0;
        _r = new Random();
        _raise = 0;
        _turn = 0;

        // initialize players checked state 
        for (int i = 0; i < _numberOfPlayers; i++)
        {
            _playersCheckedState.Add(0); 
        }

        // declare local variables 
        Deck d;
        Random r;
        int bigBlind;
        int initialBalance; 
        bool isRunning;
        int round;
        int smallBlind;
        string playerTurn;
        List<Card> communityCards;
        List<Card> computerHand;
        List<Card> playerHand;
        List<List<Card>> playerCards;
        List<int> playersCheckedState;

        // initialize local variables 
        d = new Deck();
        communityCards = new List<Card>();
        computerHand = new List<Card>();
        isRunning = true; 
        playerHand = new List<Card>();
        round = 0;
        _winner = string.Empty; 

        // initialize the playerCards List 
        playerCards = new List<List<Card>>();
        playerCards.Add(computerHand);
        playerCards.Add(playerHand);

        // prompt the user 
        Console.Write("Please enter the starting balance for each player: ");
        initialBalance = int.Parse(Console.ReadLine());
        _computerBalance = initialBalance; 
        _playerBalance = initialBalance;

        // prompt the user 
        Console.Write("Please enter the amount of the small blind: ");
        smallBlind = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // prompt the user 
        _bigBlind = (smallBlind * 2);
        Console.Write("Setting the big blind to 2x of the small blind: " + _bigBlind);
        Console.WriteLine();

        // coin toss (decides who goes first) 
        // 0 => computer goes first
        // 1 => player goes first 
        _playerTurn = (_r.Next(0, 2) == 0) ? "Computer" : "Player";
        Console.WriteLine("Results of the coin toss: " + _playerTurn + " goes first");
        Console.WriteLine();

        // infinite loop 
        while (isRunning)
        {

            // start game 
            while (d.GetRemainingSize() > 9 && _playerBalance >= _bigBlind && _computerBalance >= _bigBlind)
            {

                // shuffle the deck 
                if (round == 0)
                    d.ShuffleDeck();

                // display a message 
                Console.WriteLine("Starting a new hand");

                // take turns 
                while (_turn < 4)
                {

                    switch (_turn)
                    {

                        case 0:

                            // deals the Pre-Flop
                            _dealer.DealPreFlop(playerCards, d);
                            Console.WriteLine("Finished dealing the Preflop");
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Computer's hand after the Preflop: ");
                            _dealer.PrintHand(computerHand);
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Your hand after the Preflop: ");
                            _dealer.PrintHand(playerHand);
                            Console.WriteLine();

                            // sets the bet == to the big blind 
                            _bet = _bigBlind;

                            // repeats until all players are in a checked / "ready" state 
                            takeTurns(); 

                            break;

                        case 1:

                            // display size of pot 
                            Console.WriteLine("Total amount in the pot: " + _pot);
                            Console.WriteLine();

                            // deals the Flop
                            communityCards = _dealer.DealFlop(d);
                            Console.WriteLine("Finished dealing the Flop");
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Computer's Hand: ");
                            _dealer.PrintHand(computerHand);
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Your Hand: ");
                            _dealer.PrintHand(playerHand);
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Community Cards after the Flop: ");
                            _dealer.PrintHand(communityCards);
                            Console.WriteLine();

                            // repeats until all players are in a checked / "ready" state 
                            takeTurns(); 

                            break;

                        case 2:

                            // display size of pot 
                            Console.WriteLine("Total amount in the pot: " + _pot);
                            Console.WriteLine();

                            // deals the Turn card 
                            communityCards.Add(_dealer.DrawCards(d, 1)[0]); 
                            Console.WriteLine("Finished dealing the Turn");
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Computer's Hand after dealing the Turn card: ");
                            _dealer.PrintHand(computerHand);
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Your Turn after dealing the Turn card: ");
                            _dealer.PrintHand(playerHand);
                            Console.WriteLine();

                            // print the community cards 
                            Console.WriteLine("Community cards after dealing the Turn card: ");
                            _dealer.PrintHand(communityCards);
                            Console.WriteLine();

                            // repeats until all players are in a checked / "ready" state 
                            takeTurns(); 

                            break;

                        case 3:

                            // display size of pot 
                            Console.WriteLine("Total amount in the pot: " + _pot);
                            Console.WriteLine();

                            // deals the River card 
                            communityCards.Add(_dealer.DrawCards(d, 1)[0]);
                            Console.WriteLine("Finished dealing the River card");
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Computer's Hand after dealing the River card: ");
                            _dealer.PrintHand(computerHand);
                            Console.WriteLine();

                            // print the hand of cards 
                            Console.WriteLine("Your Turn after dealing the River card: ");
                            _dealer.PrintHand(playerHand);
                            Console.WriteLine();

                            // print the community cards 
                            Console.WriteLine("Community cards after dealing the River card: ");
                            _dealer.PrintHand(communityCards);
                            Console.WriteLine();

                            // repeats until all players are in a checked / "ready" state 
                            takeTurns();

                            break;

                        default:
                            break; 

                    }

                    // re-initialize players checked state back to 0
                    for (int i = 0; i < _numberOfPlayers; i++)
                    {
                        _playersCheckedState[i] = 0;
                    }

                    // reset raise 
                    _raise = 0;

                    // reset bet 
                    _bet = 0;

                }

                // if the player did not fold 
                if (_cmd.ToLower() != "f")
                {

                    // evaluate hands to determine the winner 
                    _winner = _dealer.EvaluateWinner(playerHand, computerHand, communityCards); 

                    // display hand rankings 
                    Console.WriteLine("Computer's Hand Ranking: " + _dealer.DetermineHandRanking(computerHand, communityCards));
                    Console.WriteLine("Your Hand Ranking: " + _dealer.DetermineHandRanking(playerHand, communityCards));

                    // show the winner 
                    Console.WriteLine("The winner is: " + _winner);

                } 

                // show winnings 
                Console.WriteLine("Total amount of winnings in pot: " + _pot);

                // distribute the winnings 
                if (_winner == "Computer")
                {
                    _computerBalance += _pot;
                    Console.WriteLine("Computer receives: " + _pot);
                } 
                else if (_winner == "Player")
                {
                    _playerBalance += _pot;
                    Console.WriteLine("Player receives: " + _pot); 
                }
                else if (_winner == "Neither")
                {
                    _computerBalance += (_pot / 2);
                    _playerBalance += (_pot / 2);
                    Console.WriteLine("Each player receives: " + (_pot/2));
                }

                // show the remaining Balances 
                Console.WriteLine(); 
                Console.WriteLine("The Computer's Balance after round " + (round+1) + ": " + _computerBalance);
                Console.WriteLine("Your remaining Balance after round " + (round+1) + ": " + _playerBalance);
                Console.WriteLine();

                // increases round 
                round++;

                // reset turn 
                _turn = 0;

                // empty the hands 
                computerHand.Clear();
                playerHand.Clear();
                communityCards.Clear();

                // reset the pot 
                _pot = 0;

            }

            // determines the winner of the game 
            if (_computerBalance < _bigBlind)
            {
                Console.WriteLine("Congratulations! You win!! The Computer does not have enough Poker Chips to continue playing.");
                Console.WriteLine("The minnimum buy-in per Hand is the big-blind: " + _bigBlind);
                Console.WriteLine("The Computer only has: " + _computerBalance + " remaining."); 
            }
            else if (_playerBalance < _bigBlind)
            {
                Console.WriteLine("Sorry, but you've ran out of Poker Chips to play! Game over. You lose!");
                Console.WriteLine("The minnimum buy-in per Hand is the big-blind: " + _bigBlind);
                Console.WriteLine("You only have: " + _playerBalance + " remaining.");
            }
            else if (_computerBalance >= _bigBlind && _playerBalance >= _bigBlind && d.GetRemainingSize() < 9)
            {
                Console.WriteLine("Great job! The Deck has run out of cards. Game over."); 
                if (_playerBalance > _computerBalance)
                {
                    Console.WriteLine("Congratulations! You win!! You have more Poker Chips than the Computer."); 
                }
                else if (_computerBalance > _playerBalance)
                {
                    Console.WriteLine("Sorry, but the Computer has more Poker Chips than you! You lose.");
                }
            }

            // prompt the user
            Console.WriteLine();
            Console.Write("Play again? (Y/N): ");
            _cmd = Console.ReadLine(); 

            if (_cmd.ToLower() == "y")
            {

                // reset the Deck 
                d = new Deck(); 

                // reset the rounds 
                round = 0;

                // prompt the user 
                Console.Write("Please enter the starting balance for each player: ");
                initialBalance = int.Parse(Console.ReadLine());
                _computerBalance = initialBalance;
                _playerBalance = initialBalance;

                // prompt the user 
                Console.Write("Please enter the amount of the small blind: ");
                smallBlind = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // prompt the user 
                _bigBlind = (smallBlind * 2);
                Console.Write("Setting the big blind to 2x of the small blind: " + _bigBlind);
                Console.WriteLine();

                // coin toss (decides who goes first) 
                // 0 => computer goes first
                // 1 => player goes first 
                _playerTurn = (_r.Next(0, 2) == 0) ? "Computer" : "Player";
                Console.WriteLine("Results of the coin toss: " + _playerTurn + " goes first");
                Console.WriteLine();

            } 
            else if (_cmd.ToLower() == "n")
            {

                // set is Running == false 
                isRunning = false;

                // show closing message
                Console.WriteLine();
                Console.WriteLine("Thank you for playing Texas Hold Em.\nWe you hope you enjoyed playing the game.\nHave a great day!!"); 

            }

        }

        // keep the application open 
        Console.WriteLine(); 

    }

    public static void takeTurns()
    {

        // repeats until all players are in a checked / "ready" state 
        while (_playersCheckedState[0] != 1 || _playersCheckedState[1] != 1)
        {

            switch (_playerTurn)
            {

                case "Computer":

                    // player raised the big blind 
                    if (_raise > 0 && _turn == 0)
                    {

                        // display a message 
                        Console.WriteLine("The Computer is calling your raise of: " + _raise);
                        _computerBalance -= _raise - _bigBlind;

                        // adds the computer's call to the pot 
                        _pot += _raise - _bigBlind;

                        // display remaining balance 
                        Console.WriteLine("Computer's Balance after calling your raise: " + _computerBalance);
                        Console.WriteLine();

                    }
                    else if (_raise > 0 && _turn > 0)
                    {

                        // display a message 
                        Console.WriteLine("The Computer is calling your raise of: " + _raise);
                        _computerBalance -= (_raise - _bet);

                        // adds the computer's call to the pot 
                        _pot += (_raise - _bet);

                        // display remaining balance 
                        Console.WriteLine("Computer's Balance after calling your raise: " + _computerBalance);
                        Console.WriteLine();

                    }
                    else if (_raise == 0 && _turn == 0)
                    {

                        // display a message 
                        Console.WriteLine("The Computer is calling the Big-Blind of " + _bigBlind);

                        // display a message 
                        Console.WriteLine("Computer calls the big blind: " + _bigBlind);
                        Console.WriteLine();

                        // subtract the big blind from the computer's available balance 
                        _computerBalance -= _bigBlind;

                        // display a message 
                        Console.WriteLine("Computer's available balance after calling the Big-Blind: " + _computerBalance);
                        Console.WriteLine();

                        // adds the bet to the pot 
                        _pot += _bigBlind;

                    }
                    else if (_raise == 0 && _turn > 0 && _playerBalance > 0)
                    {

                        // display a message 
                        Console.WriteLine("The Computer is placing a bet");

                        // randomly generates a number between 1, and the computer's available balance 
                        _bet = _r.Next(1, _computerBalance + 1);

                        // make raise == bet 
                        _raise = _bet;

                        // display a message 
                        Console.WriteLine("Computer places a bet of: " + _bet);
                        Console.WriteLine();

                        // subtract the bet from the computer's available balance 
                        _computerBalance -= _bet;

                        // adds the bet to the pot 
                        _pot += _bet;

                        // reset player's checked state 
                        _playersCheckedState[1] = 0;

                        // display remaining balance 
                        Console.WriteLine("Computer's remaining Balance after betting: " + _computerBalance);
                        Console.WriteLine();

                    } 
                    else if (_raise == 0 && _turn > 0 && _playerBalance == 0)
                    {

                        // computer checks its turn 
                        Console.WriteLine("The Computer is checking, no raise/bet placed.");

                        // display a message 
                        Console.WriteLine("The Computer's available balance after checking: " + _computerBalance);
                        Console.WriteLine();

                    }

                    // sets the computer to a checked/ready state 
                    _playersCheckedState[0] = 1;

                    // changes the turn to the player 
                    _playerTurn = "Player";

                    break;

                case "Player":

                    if (_raise > 0 || _turn == 0)
                    {
                        // prompt the user to Raise, or Fold 
                        Console.Write("Please enter a command: C (to call), R (to raise), or F (to fold): ");
                    }
                    else if (_raise == 0)
                    {
                        // prompt the user to Raise, or Fold 
                        Console.Write("Please enter a command: C (to check), R (to raise), or F (to fold): ");
                    }

                    _cmd = Console.ReadLine();

                    switch (_cmd.ToLower())
                    {

                        case "c":

                            // computer raised 
                            if (_raise > 0 || _turn == 0)
                            {

                                if (_bet > _playerBalance)
                                {

                                    // player must go "all-in" 

                                    // display a message 
                                    Console.WriteLine("The Computer's bet of: " + _bet + " exceeds your current Balance.");
                                    Console.WriteLine("You must go \"All-In\"");

                                    // sets the bet == to the player's current remaining Balance 
                                    _bet = _playerBalance; 

                                    // subtracts the bet from the player's Balance 
                                    _playerBalance -= _bet; 

                                }
                                else
                                {

                                    // pre-flop turn 
                                    if (_turn == 0)
                                    {

                                        // display a message 
                                        Console.WriteLine("You are calling the Big-Blind amount of: " + _bigBlind);

                                        // subtracts the Big Blind from the player's available Balance 
                                        _playerBalance -= _bigBlind;

                                        // display remaining balance 
                                        Console.WriteLine("Your available Balance after calling the Big-Blind amount: " + _playerBalance);
                                        Console.WriteLine();

                                    }
                                    else
                                    {

                                        // display a message 
                                        Console.WriteLine("You are calling the Computer's bet of: " + _bet);

                                        // subtracts the bet from the players available balance 
                                        _playerBalance -= _bet;

                                        // display remaining balance 
                                        Console.WriteLine("Your available Balance after calling the Computer's bet: " + _playerBalance);
                                        Console.WriteLine();

                                    }

                                }


                                // adds the big blind to the pot 
                                _pot += _bet;

                            }
                            else
                            {

                                // display a message 
                                Console.WriteLine("You are checking, no raise/bet placed.");

                                // display a message 
                                Console.WriteLine("Your available balance after checking: " + _playerBalance);
                                Console.WriteLine();

                            }

                            break;

                        case "r":

                            // prompt the user for the amount 
                            Console.Write("How much do you want to raise?: ");
                            _raise = int.Parse(Console.ReadLine());

                            // ensure the raise is within the player's limit 
                            while ((_raise > _playerBalance) || (_raise < _bigBlind && _turn == 0) || (_raise < _bet))
                            {

                                // display a message 
                                Console.WriteLine("You've entered an invalid raise amount, please try again.");
                                Console.WriteLine();

                                // prompt the user for the amount 
                                Console.WriteLine("How much do you want to raise?: ");
                                _raise = int.Parse(Console.ReadLine());

                            }

                            // verify the value is within the acceptable range 
                            if (_raise >= _playerBalance)
                                Console.WriteLine("Player has gone all-in!");

                            // subtract from the player's available balance 
                            _playerBalance -= _raise;

                            // prints a blank line 
                            Console.WriteLine("Your remaining Balance after placing your raise: " + _playerBalance);
                            Console.WriteLine();

                            // adds the player's bet to the pot 
                            _pot += _raise;

                            // reset the computer's checked state to 0 
                            _playersCheckedState[0] = 0;

                            break;

                        case "f":

                            // display a message 
                            Console.WriteLine("Player has folded."); 

                            // ends the hand 
                            _turn = 4;

                            // sets the winner 
                            _winner = "Computer"; 

                            break;

                    }

                    // sets the player's checked state 
                    _playersCheckedState[1] = 1;

                    // changes the turn back over to the Computer 
                    _playerTurn = "Computer";

                    break;

                default:
                    break;

            }

        }

        // increases turn by 1
        _turn++;

    }

} 
