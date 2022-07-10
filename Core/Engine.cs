using Game;
namespace Core

{
    class Engine
    {


        public bool IsRunning { get; set; }
        public int Round { get; set; }
        public Deck Deck { get; private set; }
        public Player Player { get; private set; }
        public Bet Bet { get; private set; }
        void reset()
        {
            Round = 0;
        }
        public Engine(Player player, Deck deck, Bet bet)
        {
            IsRunning = true;
            Round = 0;
            Player = player;
            Deck = deck;
            Bet = bet;

        }
        public void NextRound()
        {
            Round++;
        }
        public void Run()
        {
            while (IsRunning)
            {
                Deck.PickCards();
                Console.WriteLine(Player);
                Console.WriteLine(Deck.ShowCard(Deck.Firstcard));

                Console.WriteLine("Higher(h), lower(l) or equal(e)?");
                string? Option = Console.ReadLine();
                OptionType optionType;

                switch (Option)
                {
                    case "h":
                        optionType = OptionType.High;
                        break;
                    case "l":
                        optionType = OptionType.Low;
                        break;
                    case "e":
                        optionType = OptionType.Equal;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        continue;

                }

                Console.WriteLine(Deck.ShowCard(Deck.Secondcard));

                bool hasWon = Deck.CheckIfOptionIsRight(optionType);
                string message = hasWon ? "You Won" : "You Lost";
                Console.WriteLine(message);
                if (hasWon)
                {
                    Player.Wallet.Increase(Bet.CurrentAmount);

                }
                else
                {
                    Player.Wallet.Decrease(Bet.CurrentAmount);
                }
                if (Player.Wallet.isEmpty())
                {
                    Console.WriteLine("Wallet is empty, game over!");
                    IsRunning = false;
                    continue;
                }
                NextRound();
                Console.WriteLine("Round " + Round + " Over");
            }


        }
    }



}