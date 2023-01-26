

const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine()!;

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);

string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        {
            computerMove = rock;
            break;
        }
    case 2:
        {
            computerMove = paper;
            break;
        }
    case 3:
        {
            computerMove = scissors;
            break;
        }
}
Console.WriteLine($"The computer chose {computerMove}");

if ((playerMove == "Rock" && computerMove == "Scissors") ||
        (playerMove == "Paper" && computerMove == "Rock") ||
        (playerMove == "Scissors" && computerMove == "Paper"))
{
    Console.WriteLine("You Win.");
}
else if((playerMove == "Rock" && computerMove == "Paper") ||
    (playerMove == "Paper" && computerMove == "Scissors") ||
    (playerMove == "Scissors" && computerMove == "Rock"))
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}
