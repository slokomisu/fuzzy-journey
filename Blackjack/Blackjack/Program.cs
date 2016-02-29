using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes new game object
            Game game = new Game();
            // Welcome message
            Console.WriteLine("Welcome to Blackjack!");
            Console.ReadLine();
            Console.WriteLine(); // Blank line
            // Initial 2 draws by dealer
            game.ComputerMove();
            game.ComputerMove();
            // Checks if dealer won
            if (CheckIfPlayerOrComputerHasWon(game))
                return;
            Console.WriteLine();
            game.UserMove();
            game.UserMove();
            if (CheckIfPlayerOrComputerHasWon(game))
                return;
            Console.WriteLine();




            while (true)
            {
                Console.WriteLine("Do you want to draw another card (Y/N)?");
                string input = Console.ReadLine();

                if (input == "Y" || input == "y")
                {
                    game.UserMove();
                    if (CheckIfPlayerOrComputerHasWon(game))
                        return;        
                }
                else if (game.ComputerScore > game.UserScore)
                {
                    Console.WriteLine("Computer wins");
                    return;
                 
                }                
                else
                {
                    game.ComputerMove();
                    if (CheckIfPlayerOrComputerHasWon(game))
                        return;
                }
                

                    
            }
               

        }

        public static bool CheckIfPlayerOrComputerHasWon(Game game)
        {
            if (game.ComputerWon)
            {
                Console.WriteLine("Computer wins");
                Console.ReadLine();
                return true;
                
            }
           else if (game.UserWon)
            {
                Console.WriteLine("You win!");
                Console.ReadLine();
                return true;
                
            }
            return false;

        }

    }

    
}
