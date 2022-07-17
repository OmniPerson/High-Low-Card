using Game;
namespace Core

{
    class Engine
    {


        public bool IsRunning { get; set; }
        public int Round { get; set; }
        public Deck Deck { get; private set; }
        public Player Player { get; private set; }
        public Player Ai {get; private set;}
        public Bet Bet { get; private set; }
        void reset()
        {
            Round = 0;
        }
        public Engine(Player player,Player ai, Deck deck, Bet bet)
        {
            IsRunning = true;
            Round = 0;
            Player = player;
            Ai=ai;
            Deck = deck;
            Bet = bet;

        }
        public void NextRound()
        {
            Round++;
            Console.WriteLine("Round " + Round + " Over");
            Bet.Reset();
        }

        private OptionType GetAiDecision(){
            OptionType optionType;
       
             int option = new Random().Next(1, 4);
        


            switch (option)
            {
                case  1 :
                 optionType = OptionType.High;
                 break;
                 default:
                 throw new Exception("Option out of range");
                
                 case  2 :
                 optionType = OptionType.Low;
                 break;
                 case 3 :
                 optionType = OptionType.Equal;
                 break;
            


            }
        


            return optionType;
        
        }

        public void Run()
        {
            while (IsRunning)
            {
                Deck.PickCards();
                Console.WriteLine(Player);
                Console.WriteLine(Deck.ShowCard(Deck.Firstcard));

                //AI PICKS DECISION AND SHOWS ai optiontype
                OptionType aioption = GetAiDecision();
        
                Console.WriteLine("Opponent chose " + aioption);

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
                RiseSection();
                Console.WriteLine(Deck.ShowCard(Deck.Secondcard));

                bool hasWon = Deck.CheckIfOptionIsRight(optionType);
                
                bool hasAiWon = Deck.CheckIfOptionIsRight(aioption);
                if (hasAiWon)
                {
                    Ai.Wallet.Increase(Bet.CurrentAmount);

                }

                string message = hasWon ? "You Won" : "You Lost";
                Console.WriteLine(message);
                if (hasWon)
                {
                    Player.Wallet.Increase(Bet.CurrentAmount);

                }
               
                if (Player.Wallet.isEmpty())
                {
                    Console.WriteLine("Wallet is empty, game over!");
                    IsRunning = false;
                    continue;
                }
                  if (Ai.Wallet.isEmpty())
                {
                    Console.WriteLine("Opponent has ran out of funds!; game over!");
                    IsRunning = false;
                    continue;
                }

                //check ai's wallet
                NextRound();
                
            }


        }
        private void RiseSection()
        {//CHECK IF AI HAS A DIFFERENT CHOICE THATN THE PLAYER THEN START THE RAISE 
        //Console.WriteLine("Oppponent chose to raise by " + AiRaise);
            Console.WriteLine("Do you want to rise? (Y/n) ");
            string? option = Console.ReadLine();
            if (option == "n")
            {
                return;
            }


            int amount;
            do
            {
                Console.WriteLine("With how much do you wanna rise?");
                option = Console.ReadLine();
                amount = option != null ? Int32.Parse(option) : 0;
                if (Player.Wallet.Lesser(Bet.CurrentAmount + amount))
                {
                    Console.WriteLine("You don't have enough enough money to bet.");
                }
            } while (Player.Wallet.Lesser(Bet.CurrentAmount + amount));
            
                Bet.Rise(amount);
                Player.Wallet.Decrease(amount);

                Ai.Wallet.Decrease(amount);
                Bet.Rise(amount);

    
            } 
        }
    }



}