using Game;
using Core;
Console.WriteLine("Choose an username");
var name = Console.ReadLine();
Console.WriteLine("Welcome " + name);
var deck = new Deck();
var bet = new Bet(50);
var player = new Player(name, new Wallet(100));
var ai = new Player(name, new Wallet(100) );
var engine = new Engine( player, ai, deck, bet);

engine.Run();
