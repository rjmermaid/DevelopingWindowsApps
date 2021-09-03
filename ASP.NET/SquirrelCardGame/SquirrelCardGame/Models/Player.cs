using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquirrelCardGame.Models
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        
        public Player()
        {
            Hand = new List<Card>();
        }
        public void Go(Card cardToRemove)
        {
            if (Hand.Count == 0)
                throw new InvalidOperationException("No cards in hand");
            Hand.Remove(cardToRemove);
        }
        public void DealCards(List<Card> cards)
        {
            Hand.Clear();
            Hand.AddRange(cards);
        }
    }
}
