using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                // Input: Player's choice
                Console.WriteLine("Press 1 for Rock, 2 for Paper, and 3 for Scissors or 4 to Quit:");
                int player_1 = Convert.ToInt32(Console.ReadLine());

                // Loop break
                if (player_1 == 4)
                {
                    break;
                }

                // Generate a random choice for Player 2 (the computer)
                int player_2 = random.Next(1, 4);
                Console.WriteLine("Player 2 (Computer) chose: {0}", player_2);

                // Checking multiple conditions
                if (player_1 == player_2)
                {
                    Console.WriteLine("It's a Tie!");
                }
                else if ((player_1 == 1 && player_2 == 3) || (player_1 == 2 && player_2 == 1) || (player_1 == 3 && player_2 == 2))
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Player 2 wins!");
                }
            }
            Console.WriteLine("Hope you enjoyed the game.");

        }
    }
}
