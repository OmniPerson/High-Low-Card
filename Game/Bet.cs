namespace Game
{
    class Bet
    {

        public int MinAmount { get; private set; }

        public int CurrentAmount { get; private set; }
        public int Split { get => CurrentAmount / 2; }

        public Bet(int amount)
        {
            MinAmount = CurrentAmount = amount;


        }
        public void Rise(int amount)
        {
            CurrentAmount += amount;
        }
        public void Reset()
        {
            CurrentAmount = MinAmount;
        }

    }

}