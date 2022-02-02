using System;

namespace starlink
{
    //Handles drawing cards.
    class Card
    {
        public int draw1;
        public int draw2;

        //Method to generate a random card.
        public int randomCard()
        {
            Random numberGen = new Random();
            int cardNum = numberGen.Next(1, 14);
            return cardNum;
        }

    }

    //Directs the flow of the game
    class Director
    {
        Card card = new Card();
        int myScore = 300;

        // Depending on the guess of the user, we either reduce their score by #75 or increase it by #100
        public void GetInput()
        {
            Console.Write("Higher or lower? [h/l]: ");
            string userInput = Console.ReadLine();

            //Handling for the next card being either higher or lower
            if ((card.draw2 < card.draw1 && userInput == "l") || (card.draw2 > card.draw1 && userInput == "h"))
            {
                myScore = myScore + 100;
            } 
            else if (card.draw2 == card.draw1)
            {
                myScore = myScore;
            }
            else
            {
            myScore = myScore - 75; 
            }

            //Handling for the next card being the same
            

            //Ends the game if the player reaches 0 points
            if (myScore <= 0)
            {
                Console.WriteLine("Game over!");
                Environment.Exit(0);
            }
        }

        // Depending on what the uer enters, we either continue the game or we end the game
        public void PlayGame()
        {
            string playAgain = "y";
            while (playAgain == "y")
            {
                //Calling method to draw cards
                card.draw1 = card.randomCard();
                card.draw2 = card.randomCard();

                //The game interface
                Console.WriteLine();
                Console.WriteLine($"The card is: {card.draw1}");
                GetInput();
                System.Console.WriteLine($"Next card was: {card.draw2}");
                Console.WriteLine($"Your score is: {myScore}");
                Console.Write("Play again? [y/n]: ");
                playAgain = Console.ReadLine();
            }
            Console.WriteLine("\nThank you. Goodbye!\n");
        }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            // Starting the game
            Director director = new Director();
            director.PlayGame();
        }
    }
}
