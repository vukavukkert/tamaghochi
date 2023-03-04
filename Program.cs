using stack;

Console.WriteLine("Who do you prefer? Cats or Dogs?");
string answer = Console.ReadLine().ToLower();
switch (answer)
{
    case "cats": Game.gameCat(); break;
    case "dogs": Game.gameDog(); break;
}


