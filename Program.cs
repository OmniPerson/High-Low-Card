using Game;
using Core;
Console.WriteLine("Choose an username");
var Name = Console.ReadLine();
Console.WriteLine("Welcome " + Name);
var engine = new Engine();
var deck = new Deck();
var Wallet = new Wallet(500);

while (engine.IsRunning)
{
    deck.PickCards();
    Console.WriteLine("Your current balance is " + Wallet);
    Console.WriteLine(deck.ShowCard(deck.Firstcard));

    Console.WriteLine("Higher(h) or lower(l)?");
    string? Option = Console.ReadLine();
    OptionType optionType = Option == "h" ? OptionType.High : OptionType.Low;
    
    
    Console.WriteLine(deck.ShowCard(deck.Secondcard));
    if (Option == null)
    {
        Console.WriteLine("You Lost");
        return;
    }
    
    string message = deck.CheckIfOptionIsRight(Option.Equals("h")) ? "You Won" : "You Lost";
    Console.WriteLine(message);

    engine.NextRound();
    Console.WriteLine("Round " + engine.Round + " Over");
}

