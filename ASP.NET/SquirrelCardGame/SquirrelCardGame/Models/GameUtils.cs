using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquirrelCardGame.Models
{
    public static class GameUtils
    {
        private static readonly int[] CardNamePoints = {0,0,0,10,2,3,4,11};
        public static int GetCardPoint(CardName cardName)
        {
            return CardNamePoints[(int)cardName];
        }
    }
}
