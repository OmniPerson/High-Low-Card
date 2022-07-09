namespace Game
{
    class Player
    {

        public string? Name { get; set; }
        public Wallet Wallet { get; private set; }
        public Player(string? name, Wallet wallet)
        {
            Name = name;
            Wallet = wallet;

        }
        public override string ToString()
        {
            return Name+ " Wallet: " + Wallet.ToString();
        }
    }



}