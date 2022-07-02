
int FirstCard = new Random().Next(1, 14);
Console.WriteLine(FirstCard);

Console.WriteLine("Higher(h) or lower(l)?");
string?  Option = Console.ReadLine();

int NextCard = new Random().Next (1,14);
Console.WriteLine(NextCard);
if (Option == null){
    Console.WriteLine ("You Lost");
    return;
}
if (Option.Equals("h")){
    if(NextCard >= FirstCard){
        Console.WriteLine("You Won");
    
    }
    else{ Console.WriteLine("You Lost");}
}
else {
    if(NextCard<= FirstCard){
        Console.WriteLine ("YouWon");
        
    }
    else {Console.WriteLine("You lost");}
}

