using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public Card(string suit, string rank) // TODO Verify if suit or rank are valid values
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public static string[] ValidSuits()
        {
            string[] suit = new string[] { "Hearts", "Diamonds", "Spades", "Clubs" };
            return suit;
        }

        public static string[] ValidRanks()
        {
            string[] rank = new string[] {"Ace", "2", "3", "4", "5", "6",
            "7", "8", "9", "10", "Jack", "Queen", "King"};
            return rank;
        }

        public int GetValue()
        {
            if (Rank == "Ace")
                return 1;
            else if (Rank == "Jack")
                return 11;
            else if (Rank == "Queen")
                return 12;
            else if (Rank == "King")
                return 13;
            else
                return int.Parse(Rank);
        }

        public string GetFace()
        {
            return Rank + " of " + Suit;
        }

    }
}
