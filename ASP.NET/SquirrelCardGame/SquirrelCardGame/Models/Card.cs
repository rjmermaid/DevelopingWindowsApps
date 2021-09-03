using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquirrelCardGame.Models
{
    public class Card
    {
        public Suit Suit { get; }
        public CardName Name { get; }

        public Card(Suit suit, CardName name)
        {
            this.Suit = suit;
            this.Name = name;
        }

        public int Point => GameUtils.GetCardPoint(Name);

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (obj is not Card other)
                return false;
            if (GetHashCode() != other.GetHashCode())
                return false;
            return Suit == other.Suit && Name == other.Name;
        }

        public override int GetHashCode()
        {
            return ((int)Suit) * 13 + ((int)Name);
        }
    }

}
