using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        public bool UserWon { get; set; }
        public bool ComputerWon { get; set; }
        public int UserScore { get; set; }
        public int ComputerScore { get; set; }
        public Deck Deck { get; set; }

        public Game()
        {
            UserWon = false;
            ComputerWon = false;
            UserScore = 0;
            ComputerScore = 0;
            Deck = new Deck();
        }

        public void ComputerMove()
        {
            Card card = Deck.DrawCard();

            if (UserScore >= 18 && ComputerScore == 20)
                ComputerScore += card.GetValue();
            else if (UserScore == 20 && ComputerScore == 19)
                ComputerScore += card.GetValue();
            else
                ComputerScore += card.GetValue();

            Console.WriteLine("Computer drew {0}, and has {1} points now",
                card.GetFace(),
                ComputerScore);

            if (ComputerScore == 21)
                ComputerWon = true;
            if (ComputerScore > 21)
                UserWon = true;
        }

        public void UserMove()
        {
            Card card = Deck.DrawCard();
            UserScore += card.GetValue();

            Console.WriteLine("User drew {0}, and has {1} points now",
                card.GetFace(),
                UserScore);

            if (UserScore == 21)
                UserWon = true;
            if (UserScore > 21)
                ComputerWon = true; 
        }

    }
}
