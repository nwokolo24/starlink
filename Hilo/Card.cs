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
            int cardNum = numberGen.Next(1, 13);
            return cardNum;
        }

    }
}