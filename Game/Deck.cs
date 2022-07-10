namespace Game
{
    class Deck
    {
        public int Firstcard { get; private set; }
        public int Secondcard { get; private set; }
        public string ShowCard(int number)
        {
            switch (number)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";

                default:
                    return number.ToString();
            }
        }
        public bool CheckIfOptionIsRight(OptionType optionType)
        {

            switch (optionType)
            {

                case OptionType.High:
                    return Secondcard > Firstcard;

                case OptionType.Low:
                    return Secondcard < Firstcard;

                case OptionType.Equal:
                    return Secondcard == Firstcard;

                default:
                    return false;


            }


        }


        public void PickCards()
        {
            Firstcard = new Random().Next(1, 14);
            Secondcard = new Random().Next(1, 14);
        }
    }

}
