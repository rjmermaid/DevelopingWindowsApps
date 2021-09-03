using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquirrelCardGame.Models
{
    public class Game
    {
        public Player Player1 { get; }
        public Player Player2 { get; }
        public Player Player3 { get; }
        public Player Player4 { get; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public Suit Trump
        {
            get; set;
        }

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            Player3 = new Player();
            Player4 = new Player();
        }
        public void StartRound()
        {
            // Set trump to random
            // Deal cards to players
        }
        public void Go(Card chosenCard)
        {
            // Player1.Go(chosenCard);
            // Choose cards that players go with on this play
            // Player2.Go(chosenCard); Player3.Go(chosenCard); Player4.Go(chosenCard);
            // Compute the result
            // Score1++; or Score2++;
            // Check if the game is over
            // if yes => true if not => false
        }
    }
}
