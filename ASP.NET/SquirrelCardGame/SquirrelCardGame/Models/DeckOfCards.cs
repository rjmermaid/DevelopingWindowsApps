using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquirrelCardGame.Models
{
    public class DeckOfCards 
    {
        const int NUM_OF_CARDS = 32;
        private Card[] deck;
        public DeckOfCards()
        {
            deck = new Card[NUM_OF_CARDS];
        }
        public Card[] getDeck { get { return deck; } }

        public void setUpDeck()
        {
            int i = 0;
            int a = 2;
            foreach(Suit p in Enum.GetValues(typeof(Suit)))
            {
                foreach(CardName n in Enum.GetValues(typeof(CardName)))
                {
                    deck[i] = new Card(p,n);
                    i++;
                }
            }
        }
        public void ShuffleCards()
        {
            Random rnd = new Random();
            Card temp;
            for(int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for(int i = 0; i < NUM_OF_CARDS; i++)
                {
                    int secondCardIndex = rnd.Next(8);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp; 
                }
            }
        }
    }
}
