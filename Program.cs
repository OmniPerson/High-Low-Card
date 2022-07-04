using Game;

Console.WriteLine("Choose an username");
var Name = Console.ReadLine();
Console.WriteLine("Welcome "+ Name);
var deck = new Deck();
var Wallet = new Wallet(500);
var Round = 0;
while (true){
deck.PickCards();
Console.WriteLine("Your current balance is " + Wallet);
Console.WriteLine(deck.ShowCard(deck.Firstcard));

Console.WriteLine("Higher(h) or lower(l)?");
string?  Option = Console.ReadLine();

Console.WriteLine(deck.ShowCard(deck.Secondcard));
if (Option == null){
    Console.WriteLine ("You Lost");
    return;
}
if (deck.CheckIfOptionIsRight(Option.Equals("h"))){
    Console.WriteLine ("You Won");

}
else Console.WriteLine ("You lost");
Round++;
Console.WriteLine("Round " + Round + " Over");
}

