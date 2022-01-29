using System;
using System.Collections.Generic;

namespace starlink
{

    public class Director 
    {  
        Card card = new Card();
        int myScore = 300;

        public Director()
        {
            card.draw1 = card.randomCard();
            card.draw2 = card.randomCard();
        }
       
        public void UpdateScore(string userInput)
        { 
            if ((card.draw2 < card.draw1 && userInput == "l") || (card.draw2 > card.draw1 && userInput == "h"))
            {
                myScore = myScore + 100;
            } 
            else
            {
            myScore = myScore - 75; 
            }
        }

        // Depending on what the uer enters, we either continue the game or we end the game
        void PlayGame()
        {
            string playAgain = "y";
            while (playAgain == "y")
            {
                //The game interface
                Console.WriteLine();
                Console.WriteLine($"The card is: {card.draw1}");
                Console.Write("Higher or lower? [h/l]: ");
                string userInput = Console.ReadLine();
                System.Console.WriteLine($"Next card was: {card.draw2}");
                UpdateScore(userInput);
                Console.WriteLine($"Your score is: {myScore}");
                Console.Write("Play again? [y/n]: ");
                playAgain = Console.ReadLine();
            }
            Console.WriteLine("\nThank you. Goodbye!\n");
        }

    }
}