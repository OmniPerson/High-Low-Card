using Game;
using Core;
Console.WriteLine("Choose an username");
var name = Console.ReadLine();
Console.WriteLine("Welcome " + name);
var deck = new Deck();
var player = new Player(name, new Wallet(500));
var engine = new Engine( player, deck);

engine.Run();
