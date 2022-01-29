// We are still working on Implementing the Card class, but here is a demo
int randomNumber = 9;
int check = 5;
int myScore = 300;

// Starting the game
PlayGame();

// Depending on the guess of the user, we either reduce their score by #75 or increase it by #100
void GetInput()
{
    Console.Write("Higher or lower? [h/l]: ");
    string userInput = Console.ReadLine();

    if ((check < randomNumber && userInput == "l") || (check > randomNumber && userInput == "h"))
    {
        myScore = myScore + 100;
    } 
    else
    {
       myScore = myScore - 75; 
    }

    randomNumber = check;
}

// Depending on what the uer enters, we either continue the game of we end the game
void PlayGame()
{
    string playAgain = "y";
    while (playAgain == "y")
    {
        Console.WriteLine($"The card is: {randomNumber}");
        GetInput();
        System.Console.WriteLine($"Next card was: {check}");
        Console.WriteLine($"Your score is: {myScore}");
        Console.Write("Play again? [y/n]: ");
        playAgain = Console.ReadLine();
    }
    Console.WriteLine("\nThank you. Goodbye!\n");
}