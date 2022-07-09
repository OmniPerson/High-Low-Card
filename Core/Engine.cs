using Game;
namespace Core

{
    class Engine
    {


        public bool IsRunning { get; set; }
        public int Round { get; set; }
        public Deck Deck { get; private set; }
        public Player Player { get; private set; }
        void reset()
        {
            Round = 0;
        }
        public Engine(Player player, Deck deck)
        {
            IsRunning = true;
            Round = 0;
            Player = player;
            Deck = deck;
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

                Console.WriteLine("Higher(h) or lower(l)?");
                string? Option = Console.ReadLine();
                OptionType optionType = Option == "h" ? OptionType.High : OptionType.Low;


                Console.WriteLine(Deck.ShowCard(Deck.Secondcard));
                if (Option == null)
                {
                    Console.WriteLine("You Lost");
                    return;
                }

                string message = Deck.CheckIfOptionIsRight(optionType) ? "You Won" : "You Lost";
                Console.WriteLine(message);

                NextRound();
                Console.WriteLine("Round " + Round + " Over");
            }


        }
    }



}